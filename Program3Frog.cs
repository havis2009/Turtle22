﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.FrogLib;

namespace Turtle22
{
    internal partial class Program
    {
        static void Main3()
        {
            BrownFrog f0 = new BrownFrog(4, "f0");
            BrownFrog f1 = new BrownFrog(5, "f1");
            BrownFrog f2 = new BrownFrog(6, "f2");

            GreenFrog f4 = new GreenFrog(0, "f4"); 
            GreenFrog f5 = new GreenFrog(1, "f5"); 
            GreenFrog f6 = new GreenFrog(2, "f6");



            f0.Move();
            f6.Jump();
            f5.Move();
            f0.Jump();
            f1.Jump();
            f2.Move();
            f6.Move();
            f6.Jump();
            f5.Jump();
            f4.Jump();
            f0.Move();
            f1.Jump();
            f2.Jump();
            f5.Move();
            f4.Jump();
            f2.Move();


        }
    }
}
