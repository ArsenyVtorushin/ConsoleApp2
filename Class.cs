﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ClassA
    {
        public void MethodA(ClassB classB)
        {
            classB.MethodB(this);
        }
        public void Add(ref int a)
        {
            a++;
        }
    }
    public class ClassB
    {
        public void MethodB(ClassA classA)
        {
            Console.WriteLine("Shit");
        }
    }
}

namespace Engine
{
    namespace Renderer
    {
        class Vector3D { }
    }
    namespace Physics
    {
        class Vector3D { }
    }
}
