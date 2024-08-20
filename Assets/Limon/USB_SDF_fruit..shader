Shader "Unlit/USB_SDF_fruit."

{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Edge ("Edge", Range(-0.5,0.5)) = 0.0
        _PlaneTex ("Plane Texture", 2D) = "white" {}
        _CircleCol ("Circle Color", Color) = (1,1,1,1)
        _CircleRad ("Circle Radius", Range (0.0, 0.5)) = 0.45
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100
        Cull Off

        Pass
        {
            CGPROGRAM
// Upgrade NOTE: excluded shader from DX11; has structs without semantics (struct v2f members hitPos)
#pragma exclude_renderers d3d11

            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
             
            float planeSDF (float3 ray_position)
            {
                float plane = ray_position.y - _Edge;
                return plane;
            }

            #define MAX_MARCHING_STEPS 50

            #define MAX_DISTANCE 10.0

            #define  SURFACE_DISTANCE 0.001

            float sphereCasting(float3 ray_origin, float3 ray_direction)
            {
               float distance_origin =0;
               for ( int = 0; i < MAX_MARCHING_5TEPS; i++)
               {
                 float3 ray_position = ray_origin + ray_direction* distance_origin;
                 float distace_scene = planeSDF(ray_position);
                 distance_origin += distace_scene;

                 if(distace_scene < SURFACE_DISTANCE || distance_origin > MAX_MARCHING_STEPS);
                 break;
               }
               return distance_origin;
            }

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                float3 hitPos = TEXCOORD1;
            
            };

            sampler2D _MainTex;
            sampler2D _PlaneTex;
            float4 _MainTex_ST;
            float4 _CircleCol;
            float _CircleRad;
            float _Edge;


            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.hitPos = v.vertex;

                return o;
            }

            fixed4 frag (v2f i, bool face : SV_isFrontFace) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                float3 ray_origin = mul(unity_WorldToObject, float4(_WorldSpaceCameraPos,1));

                float3 ray_direction = normalize(i.hitPos - ray_origin);
                float t = sphereCasting (ray_origin, ray_direction);
                float4 planeCol = 0;
                float4 circleCol = 0;
                if(t < MAX_DISTANCE)
                {
                  float3 p = ray_origin + ray_direction * t;
                  float2 uv_p = p.xz;
                  float l = pow(-abs(_Edge), 2) + pow(-abs(_Edge) - 1, 2);
                  planeCol = tex2D(_PlaneTex, (uv_p(1 - abs(pow(_Edge * l, 2)))) - 0.5);
                  float c = length(uv_p);
                  // apply the same scheme to the circle’s radius
                  // this way, we modify the its size
                  circleCol = (smoothstep(c - 0.01, c + 0.01, _CircleRad - abs(pow(_Edge * (1 * 0.5), 2))));
                  planeCol = tex2D(_PlaneTex, (uv_p(1 - abs(pow(_Edge * l, 2)))) - 0.5);
                  planeCol *= circleCol;
                  // add the circle and apply color
                  planeCol += (1 - circleCol) * _CircleCol;
                }
                
                if (i.hitPos.y > _Edge)
                discard;

                return face ? col : planeCol;
            }
            ENDCG
        }
    }
}


