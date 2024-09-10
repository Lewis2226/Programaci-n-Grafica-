Shader "Custom/StencilGraph"
{
    SubShader
    {
        Pass
        {
            ColorMask 0
            Zwrite off

            Stencil
            {
                Ref 2
                Comp Always
                Pass Replace
            }
        }
    }
}
