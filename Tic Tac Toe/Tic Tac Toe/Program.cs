namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }


        public static void menu()
        {


            int select = 0;
            Game game = new Game();
            while (true)
            {
                Console.WriteLine("=========================\n   Welcome at X-O Game\n=========================\n");
                Console.WriteLine("1] Single Plyer\n2] Multi player\n3] Exit");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unknown choice!");
                    continue;
                }

                if (select == 1)
                {
                    Console.Clear();
                    Game.SinglePlayer();
                    Console.WriteLine("Click enter to back");
                    String back = Console.ReadLine();
                    Console.Clear();
                }
                else if (select == 2)
                {
                    Console.Clear();
                    Game.MultiPlayer();
                    Console.WriteLine("Click enter to back");
                    String back = Console.ReadLine();
                    Console.Clear();
                }
                else if (select == 3)
                {
                    Console.Clear();
                    break;
                }
                else
                {

                    Console.WriteLine("Unknown choice!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

            }
        }


    }
}
