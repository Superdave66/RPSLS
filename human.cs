using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human:Player
    {
        public override void ChooseGeasture()
        {

            Console.WriteLine("Choose your Geasture");
            Geasture = Console.ReadLine();
        }
    }
}
 