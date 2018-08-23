﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpGL;

namespace DepthPeeling.DualPeeling
{
    public static partial class Shaders
    {
        public const string initVert = @"#version 330 core
  
layout(location = 0) in vec3 vVertex; //object space vertex position

//uniform
uniform mat4 mvpMat;  //combined modelview projection matrix

void main()
{  
    //get the clipspace vertex position
    gl_Position = mvpMat*vec4(vVertex.xyz,1);
}
";
        public const string initFrag = @"#version 330 core

out vec4 outColor; //output fragment colour

uniform vec4 vColor;	//colour uniform

void main()
{
    outColor.x = -gl_FragCoord.z;
    outColor.y = gl_FragCoord.z;
}
";

    }
}
