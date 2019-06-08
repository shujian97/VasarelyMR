// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/MinFace" {
	Properties{
		_MainTex("texture",2D) = "white"{}
        _Radius("radius",float) = 0
		_CenterX("centerX",float) = 0.2
		_CenterY("centerY",float) = 0.2
	}
		SubShader{
		tags{"Queue" = "Transparent" "RenderType" = "Transparent"}
		Pass{
		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag
		#include "UnityCG.cginc"
		float4 _Color;
		sampler2D _MainTex;
		float _CenterX;
		float _CenterY;
		struct v2f {
			float4 pos : SV_POSITION;
			float2 uv : TEXCOORD0;
		};
		float4 _MainTex_ST;
		v2f vert(appdata_base v) {
		v2f o;
		o.pos = UnityObjectToClipPos(v.vertex);
		o.uv = TRANSFORM_TEX(v.texcoord,_MainTex);
		return o;
		};
		float newX = 0;
		float newY = 0;
		float _Radius;
		float theta = 0;
		half4 frag(v2f i) :COLOR
		{
        
		float tx = i.uv.x - _CenterX;
		float ty = i.uv.y - _CenterY;

		 theta = atan2(ty, tx);
		float radius = sqrt(tx * tx + ty * ty);
		float newR = sqrt(radius)*0.5;
        float distan=tx*tx+ty*ty;
        float real_radius=_Radius/2;
        if(distan<_Radius*_Radius){
		newX = _CenterX + newR * cos(theta);
		newY = _CenterY + newR * sin(theta);
		if (newX < 0)
		  {
			 newX = 0;
		  }
		  if (newX > 1)
		  {
			 newX = 1;
		  }
		   if (newY > 1)
		  {
			 newY = 1;
		  }
		   if (newY < 0)
		  {
			 newX = 0;
		  }
          }else{
          newX=i.uv.x;
          newY=i.uv.y;
          }
		float2 uv_earth = float2(newX,newY);
		half4 texcolor_earth = tex2D(_MainTex,uv_earth);

		return texcolor_earth;
		}
		ENDCG
		}
		}
			FallBack "Diffuse"
}