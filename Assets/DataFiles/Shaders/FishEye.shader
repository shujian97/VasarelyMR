Shader "Custom/FishEye" 
{
    Properties
    {
        _MainTex("", 2D) = "white" {}
        _Distortion("Distortion",float) = -2
        _Radius("radius",float)=0.5
        _CenterX("centerX",float)=0.5
        _CenterY("centerY",float)=0.5
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct v2f 
            {
                float4 pos : POSITION;
                half2 uv : TEXCOORD0;
            };

            //Our Vertex Shader 
            v2f vert(appdata_img v) 
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = MultiplyUV(UNITY_MATRIX_TEXTURE0, v.texcoord.xy);
                return o;
            }

            sampler2D _MainTex;
            float _Distortion;
            
            float _Radius;
            float _CenterX;
            float _CenterY;
            //Our Fragment Shader
            float4 frag(v2f i) : COLOR
            {
                // lens distortion coefficient
                float k = -0.15;

                
                float f = 0;
                
                float l = 0.3;
                
                float tx = i.uv.x - _CenterX;
                float ty = i.uv.y - _CenterY;
                float radius = sqrt(tx * tx + ty * ty);
                float newR = sqrt(radius)*0.5;
                float distan=tx*tx+ty*ty;
                float real_radius=_Radius/2;
                
                float r2 = (i.uv.x - _CenterX) * (i.uv.x - _CenterX) + (i.uv.y - _CenterY) * (i.uv.y - _CenterY);
                float x;
                float y;
                if(distan<_Radius*_Radius){
                //only compute the cubic distortion if necessary
                
                f = 1 + l * (k + _Distortion * sqrt(r2));
                

                // get the right pixel for the current position
                x = f*(i.uv.x - _CenterX) + _CenterX;
                y = f*(i.uv.y - _CenterY) + _CenterY;
                }else{
                x=i.uv.x;
                y=i.uv.y;
                }
                float3 inputDistord = tex2D(_MainTex,float2(x,y));

                return float4(inputDistord.r,inputDistord.g,inputDistord.b,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}