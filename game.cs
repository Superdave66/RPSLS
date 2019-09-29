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
        

        public void AddRules() {
            rules.Add("Rock Beats Scissors and Lizard");
            rules.Add("Paper beats Rock and Spock");
            rules.Add("Scissors beats Paper and Lizard ");
            rules.Add("Lizard beats spock and Paper");
            rules.Add("Spock beats Rock and Scissors ");
            foreach (string rule in rules) ;
            Console.Write(rules);
           
         
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
                player1 = new Computer();
                player2 = new Computer();
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
                        if (player2.geasture is "Paper") {
                            Console.Write(player2.name + "wins");
                            Console.ReadLine();
                        }

                        else if
                            (player2.geasture is "Lizard")
                        {
                            Console.WriteLine(player1 + "wins");
                            Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();

                        }
                        else if
                            (player2.geasture is "Scissors")
                        {
                            Console.WriteLine(player1 + "Wins");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("this is a draw");
                            Console.ReadLine();
                        }
                        break;
                    }
                case "Paper":
                    { if (player2.geasture is "Rock") ;
                        {
                            Console.WriteLine(player1 + "wins");
                            Console.ReadLine();
                        }

                        if (player2.geasture is "Lizard")
                        {
                            Console.WriteLine(player1 + "wins");
                            Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();

                        }
                        else if
                            (player2.geasture is "Scissors")
                        {
                            Console.WriteLine(player1 + "Wins");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("this is a draw");
                            Console.ReadLine();
                        }
                        break;
                    }
                case "Scissors":
                    {
                        if (player2.geasture is "Rock") ;
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();
                        }

                        if (player2.geasture is "Lizard")
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.WriteLine(player1 + "wins");
                            Console.ReadLine();

                        }
                        else if
                            (player2.geasture is "Paper")
                        {
                            Console.WriteLine(player1 + "Wins");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("this is a draw");
                            Console.ReadLine();
                        }
                        break;
                    }
                case "Lizard":
                    {
                        if (player2.geasture is "Rock") ;
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();
                        }

                        if (player2.geasture is "Scissors")
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Spock")
                        {
                            Console.WriteLine(player1 + "wins");
                            Console.ReadLine();
                        }
                        else if
                            (player2.geasture is "Paper")
                        {
                            Console.WriteLine(player1 + "Wins");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("this is a draw");
                            Console.ReadLine();
                        }
                        break;
                    }
                default:
                    {
                        if (player2.geasture is "Rock") ;
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();
                        }

                        if (player2.geasture is "Scissors")
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();
                        }


                        else if
                            (player2.geasture is "Lizard")
                        {
                            Console.WriteLine(player2 + "wins");
                            Console.ReadLine();
                        


                    }
                        else if
                            (player2.geasture is "Paper")
                        {
                            Console.WriteLine(player1 + "Wins");
                            Console.ReadLine();
                        }
                    
                        else
                        {
                            Console.WriteLine("this is a draw");
                            Console.ReadLine();
                            }
                    }break;
            }

        }





        public void RunGame()
        {
            AddRules();
            NumberOfPlayers();
            CreatePlayers(numberofplayers);
                
            player1.GetName();
            player2.GetName();            
            player1.ChooseGeasture();
            player2.ChooseGeasture();
            GetRoundWinner(player1, player2);

        }  
        
     }  
}
