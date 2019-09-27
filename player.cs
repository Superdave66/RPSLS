using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public int score;
        public string name;
        public string geasture;
      

        public abstract string ChooseGeasture();
        public abstract string GetName();
     }
}
