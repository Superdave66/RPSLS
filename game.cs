using System;
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
        public int numberofrounds = 3;
        public string roundwinner;



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

            if (numberofplayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numberofplayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (numberofplayers == 0)
            {
                Console.WriteLine("we are sorry currently we are unable to make a computer vs computer game. that will also be included in the DLC");

            }
            else
            {
                Console.WriteLine("we are sorry but you need to buy the DLC to be able to play with more then 2 players");
                NumberOfPlayers();
            }


        }


        public void GetRoundWinner(Player player1, Player player2)
        {
            switch (player1.geasture)
            {
                case "Rock":
                    {
                        if (player2.geasture is "Paper")
                        {
                            Console.Write(player2.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }

                        else if
                            (player2.geasture is "Lizard")
                        {
                            Console.Write(player1.name + "wins round");
                            roundwinner = Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.Write(player2.name + "wins round");
                            roundwinner = Console.ReadLine();

                        }
                        else if
                            (player2.geasture is "Scissors")
                        {
                            Console.Write(player1.name + "Wins round");
                            roundwinner = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("this is a draw");
                            roundwinner = Console.ReadLine();
                        }
                        break;
                    }
                case "Paper":
                    {
                        if (player2.geasture is "Rock")
                        {
                            Console.Write(player1.name + "wins round");
                            roundwinner = Console.ReadLine();
                        }

                        else if (player2.geasture is "Lizard")
                        {
                            Console.Write(player1.name + "wins round");
                            roundwinner = Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.Write(player2.name + "wins round");
                            roundwinner = Console.ReadLine();

                        }
                        else if
                            (player2.geasture is "Scissors")
                        {
                            Console.Write(player1.name + "Wins round");
                            roundwinner = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("this is a draw");
                            roundwinner = Console.ReadLine();
                        }
                        break;
                    }
                case "Scissors":
                    {
                        if (player2.geasture is "Rock")
                        {
                            Console.Write(player2.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }

                        else if (player2.geasture is "Lizard")
                        {
                            Console.Write(player2.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.Write(player1.name + "wins Round");
                            roundwinner = Console.ReadLine();

                        }
                        else if
                            (player2.geasture is "Paper")
                        {
                            Console.Write(player1.name + "Wins Round");
                            roundwinner = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("this is a draw");
                            roundwinner = Console.ReadLine();
                        }
                        break;
                    }
                case "Lizard":
                    {
                        if (player2.geasture is "Rock")
                        {
                            Console.Write(player2.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }

                        else if (player2.geasture is "Scissors")
                        {
                            Console.Write(player2.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.Write(player1.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }
                        else if
                            (player2.geasture is "Paper")
                        {
                            Console.Write(player1.name + "Wins Round");
                            roundwinner = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("this is a draw");
                            roundwinner = Console.ReadLine();
                        }
                        break;
                    }
                default:
                    {
                        if (player2.geasture is "Rock")
                        {
                            Console.Write(player2.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }

                        else if (player2.geasture is "Scissors")
                        {
                            Console.Write(player2.name + "wins Round");
                            roundwinner = Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Lizard")
                        {
                            Console.Write(player2.name + "wins Round");
                            
                            roundwinner = Console.ReadLine();



                        }
                        else if
                            (player2.geasture is "Paper")
                        {
                            Console.Write(player1.name + "Wins Round");
                            roundwinner = Console.ReadLine();
                        }

                        else
                        {
                           Console.Write("this is a draw");
                            roundwinner = Console.ReadLine();
                            
                        }
                    }
                    break;
            }
        }

        public void GetGameWinner(Player player1, Player player2)
        {
            if (roundwinner == (player2.name + "wins Round"))
            {
                 player2.score++;
            }
            else if (roundwinner == (player1.name + "wins Round"))
            {
                player1.score++;
            }
            else
            {
                Console.WriteLine("no points are given this round");
            }
            
            while (player1.score < 2 || player2.score < 2) {
                player1.ChooseGeasture();
                player2.ChooseGeasture();
                GetRoundWinner(player1, player2);
            }
        }








        public void RunGame()
        {
            AddRules();
            NumberOfPlayers();
            CreatePlayers(numberofplayers);
           player1.name= player1.GetName();
            player2.name = player2.GetName();
          player1.geasture  =  player1.ChooseGeasture();
           player2.geasture = player2.ChooseGeasture();
           GetRoundWinner(player1, player2);
            GetGameWinner( player1,  player2);

        }  
        
     }  
}
