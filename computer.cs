using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
       
            //public new string geasture=    ChooseGeasture();
            Random random = new Random();
        public override string ChooseGeasture()
        {


           int index = random.Next(geastures.Count);
           Console.WriteLine(geastures[index]);
           return geastures[index];
         
            
        }

        public override string GetName()
        {
            Console.Write("computer");
            name = Console.ReadLine();
            return name;

        }
    }
    
}
