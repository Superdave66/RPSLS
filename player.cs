﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public int score;
        public string Name;
        public string Geasture;
      

        public abstract void ChooseGeasture();
   

    }
}