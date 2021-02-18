using System;

namespace Sport_Tracker
{
    class Program
    {
        static User User1;
        static void Main(string[] args)
        {
            Console.WriteLine("       Yo!!!");
            Console.WriteLine(string.Empty);
            var wantToQuit = false;
            User1 = new User();

            //  We display application's menu

            while (!wantToQuit)
            {
                HomeMenu();
            }
        }

        static void HomeMenu()
        {
            Console.WriteLine("1 - Poids");
            Console.WriteLine("2 - Historique");
            Console.WriteLine(string.Empty);
            int inputchoice = int.Parse(Console.ReadLine());
            

            if (inputchoice == 1)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Quel est ton poids ? ");
                Console.WriteLine(string.Empty);
                float inputweight = float.Parse(Console.ReadLine());
                Console.WriteLine(string.Empty);
                User1.AddWeight(inputweight);

            }
            else if (inputchoice == 2)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Votre historique de poids");
                User1.ReadWeight();
            }
        }
    }
}
