using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tic_Tac_Toe
{
    class Game
    {



        private static char[] CreateGame()
        {
            char[] table = new char[9];
            for (int i = 0; i < 9; i++)
                table[i] = ' ';
            return table;
        }
        private static void DisplayGame(char[] table)
        {
            String game = $" {table[0]} | {table[1]} | {table[2]}\n" +
                          $"-----------\n" +
                          $" {table[3]} | {table[4]} | {table[5]}\n" +
                          $"-----------\n" +
                          $" {table[6]} | {table[7]} | {table[8]}\n";

            Console.WriteLine(game);
        }
        private static bool CheckWinP1(char[] table)
        {
            if ((table[0] == 'X' && table[1] == 'X' && table[2] == 'X') ||
                (table[3] == 'X' && table[4] == 'X' && table[5] == 'X') ||
                (table[6] == 'X' && table[7] == 'X' && table[8] == 'X') ||
                (table[0] == 'X' && table[3] == 'X' && table[6] == 'X') ||
                (table[1] == 'X' && table[4] == 'X' && table[7] == 'X') ||
                (table[2] == 'X' && table[5] == 'X' && table[8] == 'X') ||
                (table[0] == 'X' && table[4] == 'X' && table[8] == 'X') ||
                (table[2] == 'X' && table[4] == 'X' && table[6] == 'X'))
                return true;
            return false;
        }
        private static bool CheckWinP2(char[] table)
        {


            if ((table[0] == 'O' && table[1] == 'O' && table[2] == 'O') ||
                    (table[3] == 'O' && table[4] == 'O' && table[5] == 'O') ||
                    (table[6] == 'O' && table[7] == 'O' && table[8] == 'O') ||
                    (table[0] == 'O' && table[3] == 'O' && table[6] == 'O') ||
                    (table[1] == 'O' && table[4] == 'O' && table[7] == 'O') ||
                    (table[2] == 'O' && table[5] == 'O' && table[8] == 'O') ||
                    (table[0] == 'O' && table[4] == 'O' && table[8] == 'O') ||
                    (table[2] == 'O' && table[4] == 'O' && table[6] == 'O'))
                return true;
            return false;
        }
        private static bool CheckDraw(char[] table)
        {
            bool flag = false;
            foreach (char c in table)
            {
                if (c == ' ')
                {
                    flag = true;
                }
            }
            if (!CheckWinP1(table) && !CheckWinP2(table) && !flag)
                return true;
            return false;
        }

        public static void SinglePlayer()
        {
            char[] table = CreateGame();
            DisplayGame(table);
            List<int> choice = new List<int>();
            for (int i = 0; i < 9; i++)
                choice.Add(i);
            while (true)
            {

                Console.WriteLine("Player 1 turn");
                Console.WriteLine("enter the index [0-8]");
                int n = 0;
                while (true)
                {

                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please enter index between 0 and 8");
                        continue;
                    }


                    if ((n > 8 || n < 0))
                    {

                        Console.WriteLine("Please enter index between 0 and 8");
                        continue;
                    }
                    if (table[n] != ' ')
                    {
                        Console.WriteLine("Please enter index not been choosen before");
                        continue;
                    }
                    else break;
                }
                table[n] = 'X';
                choice.Remove(n);
                Console.Clear();
                DisplayGame(table);

                if (CheckWinP1(table))
                {
                    Console.WriteLine("Player 1 won");
                    break;
                }
                if (CheckDraw(table))
                {
                    Console.WriteLine("Draw");
                    break;
                }


                Console.WriteLine("Computer turn");
                Thread.Sleep(2000);

                Random random = new Random();
                int n2 = random.Next(0, choice.Count());

                table[choice[n2]] = 'O';
                choice.Remove(choice[n2]);
                Console.Clear();

                DisplayGame(table);

                if (CheckWinP2(table))
                {
                    Console.WriteLine("Computer won");
                    break;
                }
                if (CheckDraw(table))
                {
                    Console.WriteLine("Draw");
                    break;
                }
            }


        }

        public static void MultiPlayer()
        {
            char[] table = CreateGame();
            DisplayGame(table);

            while (true)
            {

                Console.WriteLine("Player 1 turn");
                Console.WriteLine("enter the index [0-8]");
                int n = 0;
                while (true)
                {

                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please enter index between 0 and 8");
                        continue;
                    }


                    if ((n > 8 || n < 0))
                    {

                        Console.WriteLine("Please enter index between 0 and 8");
                        continue;
                    }
                    if (table[n] != ' ')
                    {
                        Console.WriteLine("Please enter index not been choosen before");
                        continue;
                    }
                    else break;
                }
                table[n] = 'X';
                Console.Clear();
                DisplayGame(table);

                if (CheckWinP1(table))
                {
                    Console.WriteLine("Player 1 won");
                    break;
                }
                if (CheckDraw(table))
                {
                    Console.WriteLine("Draw");
                    break;
                }


                Console.WriteLine("Player 2 turn");
                Console.WriteLine("enter the index [0-8]");
                int n2 = 0;
                while (true)
                {

                    try
                    {
                        n2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please enter index between o and 8");
                        continue;
                    }
                    if ((n2 > 8 || n2 < 0))
                    {
                        Console.WriteLine("Please enter index between 0 and 8");
                        continue;
                    }
                    if (table[n2] != ' ')
                    {
                        Console.WriteLine("Please enter index not been choosen before");
                        continue;
                    }
                    else break;
                }
                table[n2] = 'O';
                Console.Clear();
                DisplayGame(table);

                if (CheckWinP2(table))
                {
                    Console.WriteLine("Player 2 won");
                    break;
                }
                if (CheckDraw(table))
                {
                    Console.WriteLine("Draw");
                    break;
                }
            }


        }

    }
}