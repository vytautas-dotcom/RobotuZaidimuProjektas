﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotoDalys
{
    public class Sarvai : IDalis
    {
        public string Pavadinimas { get; set; } = "fhrx";
        public int Galia { get; set; } = 10;
        public int Kaina { get; set; } = 10;
        public int Svoris { get; set; } = 10;

        public void didejaGyvybe(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void mazejaGyvybe()
        {
            throw new NotImplementedException();
        }
    }
}
