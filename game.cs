﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    { public List<string> rules = new List<string>();
        public int numberofplayers;
        public Player player1;
        public Player player2;
        public void AddRules() {
            rules.Add("Rock Beats Scissors and Lizard");
            rules.Add("Paper beats Rock and Spock");
            rules.Add("Scissors beats Paper and Lizard ");
            rules.Add("Lizard beats spock and Paper");
            rules.Add("Spock beats Rock and Scissors ");



            foreach (string rule in rules) ;
            Console.WriteLine(rules);

        }
        public int NumberOfPlayers()
        {
            Console.WriteLine("How many people are playing?");
            numberofplayers = int.Parse(Console.ReadLine());
            ; return numberofplayers;
        }
        public void CreatePlayers(int numberofplayers) {

            if (numberofplayers == 1) {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numberofplayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                player1 = new Computer();
                player2 = new Computer();
            } 
         }
     }
}


