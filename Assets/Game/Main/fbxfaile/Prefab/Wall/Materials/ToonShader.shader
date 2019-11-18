Shader "Custom/ToonShader"
{
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _RampTex ("Ramp", 2D) = "white"{}
    }

    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200
        
        CGPROGRAM
        //ライティングのメソッド名の〇〇〇の部分を追加
        #pragma surface surf ToonRamp
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _RampTex;

        struct Input {
            float2 uv_MainTex;
        };

        fixed4 _Color;


        //ライトの方向とオブジェクトの法線の内積を取りその値に応じてRampテクスチャから値を取得している
        //ライティング用のメソッドはLightingから始まる必要がある
        //attenはライトの減衰率(attenuation)
        fixed4 LightingToonRamp (SurfaceOutput s, fixed3 lightDir, fixed atten)
        {
            half d = dot(s.Normal, lightDir)*0.5 + 0.5;
            fixed3 ramp = tex2D(_RampTex, fixed2(d, 0.5)).rgb;
            fixed4 c;
            c.rgb = s.Albedo * _LightColor0.rgb * ramp;
            c.a = 0;
            return c;
        }

        //surfシェーダでライティングの工程をフックした場合には、surfの出力にはSurfaceOutputStandard型を使えない
        //ここではSurfaceOutput型に書き換えている
        //SurfaceOutput型にはEmissionやSmoothnessは定義されていないので、surfメソッドからこれらの行も削除します。
        void surf (Input IN, inout SurfaceOutput o) {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
