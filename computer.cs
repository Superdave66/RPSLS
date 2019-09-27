using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        Random random = new Random();
        public override string ChooseGeasture()
        {
       
        
        int index = random.Next(geastures.Count);
        Console.WriteLine(geastures[index]);
            return geastures[index];
        }

    public override string GetName()
        {
            Console.WriteLine("What do you want the computer name to be?");
            name = Console.ReadLine();
            return name;
        }
    
    }
}
