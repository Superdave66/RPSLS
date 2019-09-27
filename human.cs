using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human:Player
    {   
        public override string ChooseGeasture()
        {

            Console.WriteLine("Choose your Geasture");
            geasture = Console.ReadLine();
            return geasture;
        }
        public override string GetName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }

        
        
            
     }

 }


 