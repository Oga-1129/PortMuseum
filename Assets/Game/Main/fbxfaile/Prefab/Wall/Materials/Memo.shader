//変数の型,float,half,fixedの違い
//fixed : 11bit 範囲は-2~2 1/256の精度しかない
//half : 16bit  範囲は-60000~60000、小数点以下は3桁まで
//float : 32bit 範囲は大きく精度は高い(一般的なfloat)

//分け方
//ワールド座標、UV座標を取り扱う場合はfloat
//その他は全部half
//例外的に、テクスチャをサンプリングしてその後加工しない場合fixed
//上記のルールで問題が起こったら一つ上の精度の型を使う
Shader "Custom/Memo"
{
    //Parameters
    //インスペクターに表示
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        //_BaseColor    公開する変数名
        //"Color"　インスペクタ上の表示
        //Color         型名
        //(1,1,1,1)     初期値

        //型の種類
        //Numbers and Sliders
        //Range(min,max) = Num
        //Float = Num
        //Int = Num

        //Colors and Vectors
        //Color = (Num, Num, Num, Num)
        //Vector = (Num, Num, Num, Num)

        //Texture
        //2D 　= "DefaultTexture"
        //Cube = "DefaultTexture"
        //3D 　= "DefaultTexture"
    }

    //ShaderSetting
    SubShader
    {
        //いつどのようにしてレンダリングエンジンでレンダリングするか示します。
        //Queueタグ Queue （キュー）によりオブジェクトを描画する順番を判定できます。シェーダは,オブジェクトが属するレンダリング　キューを判定し,これによっていずれかの透過シェーダが不透明のオブジェクトを描画した後に描画する,といったように判定しいきます。

        //4つの定義済みのレンダリング　キューがありますが,定義済みのキューの間に追加することは出来ます。定義済みのキューは：
            //Background - このレンダリングキューは他より前にレンダリングされる。Skyboxなどに使用される。
            //Geometry (default) - これはほとんどのオブジェクトに使用される。 不透明なジオメトリはこのキューを使用する。
            //AlphaTest - アルファテストする形状でこのキューを使用する。Geometry とは別のキューであるのはアルファテストのオブジェクトを全ての不透明のオブジェクトの後に描画するほうが効率的であるため。
            //Transparent - このレンダリングキューはGeometry とAlphaTest の後に,後ろにあるものから先に順番で,レンダリングされる。アルファブレンディングするもの（すなわち,デプスバッファに書き込みしないシェーダ）は全て,ここにあるべき（ガラス,パーティクル　エフェクト）。
            //Overlay - このレンダリングキューはオーバーレイ　エフェクトのためです。最後にレンダリングするものはここにあるべき（例えば,レンズフレア等）。

        //RenderTypeタグ
        //RenderTypeタグはシェーダを定義済みのいくつかのグループに分類する。
        //すなわちisは不透明なシェーダ,orはアルファテストのシェーダ,等々。
        //これはShader Replacement により使用され,多くの場合Camera Depth Texture を生成するのに使用します。

        //ForceNoShadowCasting タグ
        //もしForceNoShadowCasting が使用されていて,値が“True” である場合,このサブシェーダを使用するオブジェクトはシャドウを投影しない。
        //これは,透過オブジェクトに Shader Replacement を使用している場合や,別のサブシェーダからシャドウ パスを継承したくない場合にもっとも便利です。

        //IgnoreProjectorタグ
        //もしIgnoreProjector が使用されていて,値が“True” である場合,このシェーダを使用するオブジェクトはProjectors により影響されない。
        //これは,Projectorsが影響するための良い方法がないため,部分的に透過であるオブジェクトで便利です。         
        Tags { "RenderType"="Opaque" }
        LOD 200

        
        CGPROGRAM
        //{
            #pragma surface surf Standard fullforwardshadows
            #pragma target 3.0

            sampler2D _MainTex;

            struct Input
            {
                //テクスチャのuv座標
                float2 uv_MainTex;

                //視線方向
                //float3(x,y,z) viewDir 

                //ワールド座標
                //float3(x,y,z) worldPos

                //スクリーン座標
                //float4(X,Y,H,W) screenPos 
            };

            //C#のスクリプトから編集可能
            half _Glossiness;
            half _Metallic;
            fixed4 _Color;

            UNITY_INSTANCING_BUFFER_START(Props)
            UNITY_INSTANCING_BUFFER_END(Props)

            //Surface Shader
            //Vertexシェーダから出力された値（Input構造体）を入力に取り、オブジェクトの表面色（SurfaceOutputStandard）を出力
            void surf (Input IN, inout SurfaceOutputStandard o)
            {
                fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;

                //fixed3 Albedo;      // ベース (ディフューズかスペキュラー) カラー
                o.Albedo = c.rgb;

                //half Metallic;      // 0=非メタル, 1=メタル
                o.Metallic = _Metallic;

                //half Smoothness;    // 0=粗い, 1=滑らか
                o.Smoothness = _Glossiness;

                //fixed Alpha;        // 透明度のアルファ
                o.Alpha = c.a;

                //fixed3 Normal;      // 書き込まれる場合は、接線空間法線
                //half3 Emission;
                //half Occlusion;     // オクルージョン (デフォルト 1)
            }
        //}
        ENDCG
    }
    FallBack "Diffuse"
}
