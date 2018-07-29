Shader "Miikun/Test" {
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        [Enum(UnityEngine.Rendering.CompareFunction)]_StencilComp ("ステンシル比較関数", Float) = 8
        _Stencil ("ステンシルの値", Float) = 0
    }


    Subshader 
    {
        Tags { "RenderType"="Transparent" }
       
        Stencil
        {
            Ref [_Stencil]
            Comp[_StencilComp]
        }

        Pass
        {
            CGPROGRAM
            #include "UnityCG.cginc"
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            #pragma vertex vert
            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            #pragma fragment frag
            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                return fixed4(col.r, col.r, col.r, 1);
            }
            ENDCG
        }
    }

}