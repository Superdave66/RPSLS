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
        public List<string> geastures = new List<string>();
        public Player()
        {
            AddGeastures();
        }
        



            public void AddGeastures()
            {
                geastures.Add("Rock");
                geastures.Add("Paper");
                geastures.Add("Scissors");
                geastures.Add("Lizard");
                geastures.Add("Spock");
            foreach (string geasture in geastures);
            Console.Write(geastures);
            }
        
         

        public abstract string ChooseGeasture();
        public abstract string GetName();
     }
}
