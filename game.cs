using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    { public List<string> rules = new List<string>();
        int numberofplayers;
     
        public void AddRules() {
            rules.Add("Rock Beats Scissors and Lizard");
            rules.Add("Paper beats Rock and Spock");
            rules.Add("Scissors beats Paper and Lizard ");
            rules.Add("Lizard beats spock and Paper");
            rules.Add("Spock beats Rock and Scissors ");



            foreach (string rule in rules) ;
            Console.WriteLine( rules);
          
        }
        public void NumberOfPlayers() {
          
            
            }
    }

}

