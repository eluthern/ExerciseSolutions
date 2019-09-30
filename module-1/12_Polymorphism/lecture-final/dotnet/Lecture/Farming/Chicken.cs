﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal
    {        
        public Chicken() : base("CHICKEN")
        {
        }
        
        public override string MakeSoundOnce()
        {
            return "CLUCK";
        }

        public override string MakeSoundTwice()
        {
            return "CLUCK CLUCK";
        }

    }
}
