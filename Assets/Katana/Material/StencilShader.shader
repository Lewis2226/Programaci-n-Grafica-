Shader"Custom/Stencil"
{
    SubShader
    {
        Pass
        {
            ColorMask 0
            Zwrite Off
            Stencil
            {
                Ref 2
                Comp Always
                Pass Replace
            }
        }
    }
}
