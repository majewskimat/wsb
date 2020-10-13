using System;

namespace TicTacToe
{
    class Program
    {
        static char[] position = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        static int player = 1;
        static int choice;
        static int state = 0;
        static int player1Score = 0;
        static int player2Score = 0;
        private static void MenuString()
        {
            Console.WriteLine("1 => NEW GAME");
            Console.WriteLine("2 => PLAYER'S STATISTICS");
            Console.WriteLine("0 => EXIT");

        }

        public static void MenuFunctions()
        {
            int menuCase;
            do
            {
                menuCase = Int32.Parse(Console.ReadLine());

                switch (menuCase)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Player1 => X" + "\n" + "Player2 => O");
                            Console.WriteLine();

                            if (player % 2 == 0)
                            {
                                Console.WriteLine("Player 2's turn!");
                            }
                            else
                            {
                                Console.WriteLine("Player 1's turn!");
                            }
                            Console.WriteLine();

                            Board();

                            choice = int.Parse(Console.ReadLine());

                            if (position[choice] != 'X' && position[choice] != 'O')
                            {
                                if (player % 2 == 0)
                                {
                                    position[choice] = 'O';
                                    player++;
                                }
                                else
                                {
                                    position[choice] = 'X';
                                    player++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("WARNING: Position {0} has already been selected with {1}. Please select other.", choice, position[choice]);
                            }
                            state = CheckState();
                        } while (state != 1 && state != -1);

                        Console.Clear();
                        Board();

                        if (state == 1)
                        {
                            Console.WriteLine("Player {0} has won", (player % 2) + 1);

                            if (player % 2 == 0)
                            {
                                player1Score++;
                            }
                            else
                            {
                                player2Score++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("It's a DRAW!");
                        }

                        MenuString();

                        break;

                    case 2:
                        Console.WriteLine("Statistics:");
                        Console.WriteLine();
                        Console.Write("Player 1 | {0} point(s) \nPlayer 2 | {1} point(s) \n", player1Score, player2Score);

                        MenuString();
                        break;

                    case 0:

                        Console.WriteLine("Goodbye");
                        break;



                    default:
                        break;
                }
            } while (menuCase != 0);
        }
        

        public static void Board()
        {
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", position[1], position[2],position[3]);
            Console.WriteLine("------------------------");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", position[4], position[5], position[6]);
            Console.WriteLine("------------------------");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", position[7], position[8], position[9]);
        }
        
        private static int CheckState()
        {
            //Horizontal Winning
            if (position[1] == position[2] && position[2] == position[3])
            {
                return 1;
            }
            else if (position[4] == position[5] && position[5] == position[6])
            {
                return 1;
            }
            else if (position[6] == position[7] && position[7] == position[8])
            {
                return 1;
            }

            //Vertical Winning
            else if (position[1] == position[4] && position[4] == position[7])
            {
                return 1;
            }
            else if (position[2] == position[5] && position[5] == position[8])
            {
                return 1;
            }
            else if (position[3] == position[6] && position[6] == position[9])
            {
                return 1;
            }

            //Diagonal Winning
            else if (position[1] == position[5] && position[5] == position[9])
            {
                return 1;
            }
            else if (position[3] == position[5] && position[5] == position[7])
            {
                return 1;
            }

            //Draw

            else if (position[1] != '1' && position[2] != '2' && position[3] != '3' && position[4] != '4' &&
                     position[5] != '5' && position[6] != '6' && position[7] != '7' && position[8] != '8')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            MenuString();
            MenuFunctions();
            
            
        }
    }
}
