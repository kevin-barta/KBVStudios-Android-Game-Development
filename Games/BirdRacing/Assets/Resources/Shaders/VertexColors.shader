Shader "Mobile/Vertex Color" {
Properties {
	_Color ("Main Color", Color) = (1,1,1,1)
	_Color2 ("Gradient Color", Color) = (1,1,1,1)
	_MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
}

SubShader
{
	Tags { "RenderType"="Opaque" }
	LOD 200

CGPROGRAM
#pragma surface surf Lambert

sampler2D _MainTex;
fixed4 _Color;
fixed4 _Color2;

struct Input
{
	float2 uv_MainTex;
	float4 screenPos;
};

void surf (Input IN, inout SurfaceOutput o) {
	float2 screenUV = IN.screenPos.xy / IN.screenPos.w;
	float2 unlit = 1;
	fixed4 c = tex2D(_MainTex, unlit) * lerp(_Color2,_Color,screenUV.y);
	o.Albedo = c.rgb;
	o.Alpha = c.a;
}
ENDCG
}

Category {
	Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
	ZWrite Off
	Alphatest Greater 0
	Blend SrcAlpha OneMinusSrcAlpha 
	SubShader {
		Material {
			Diffuse [_Color]
			Ambient [_Color]	
		}
		Pass {
			ColorMaterial AmbientAndDiffuse
			Fog { Mode Off }
			Lighting Off
			SeparateSpecular On
        	SetTexture [_MainTex] {
            Combine texture * primary, texture * primary
        }
        SetTexture [_MainTex] {
            constantColor [_Color]
            Combine previous * constant DOUBLE, previous * constant
        }  
		}
	} 
}
}