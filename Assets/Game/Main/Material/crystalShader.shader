Shader "Custom/crystalShader"
{
    SubShader{
        Tags{  "Queue"="Transparent"}
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard alpha:fade
		#pragma target 3.0

        struct Input{
            //法線ベクトル
            //オブジェクトの表面に対して垂直方向のベクトル
            float3 worldNormal;
            //視線ベクトル
            //カメラが向いている方向のベクトル
            float3 viewDir;
        };

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            o.Albedo = fixed4(1,1,1,1);
            //氷シェーダの数式
            //輪郭部分では視線ベクトルと法線ベクトルが垂直に近い角度で交わる
            //中央部分ではほぼ平行に近い角度で交わる
            //二つのベクトルのなす角度を調べるために、内積（dot producr）を使っている。

            //worldNormalとviewDirの内積をとると下記の式ように、2つのベクトルが交わる角度に変換できます。
            //（worldNormalとviewDirはどちらも正規化された長さ1のベクトルなので、|worldNormal=1、|viewDir|=1になります）
            //worldNormal * viewDir = |worldNormal| * |viewDir| * cosθ = cosθ

            //垂直に交わる場合には透明度を1、並行の場合は透明度を0にするために絶対値をとって1から引いている。
            //alpha = 1 -abs(cosθ)
            float alpha = 1 - (abs(dot(IN.viewDir, IN.worldNormal)));

            //1.5を掛けているのは見た目を調整するためのパラメータ
            o.Alpha = alpha * 1.5f;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
