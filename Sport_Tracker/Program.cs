using System;

namespace Sport_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       Yo!!!");
            Console.WriteLine(string.Empty);
            Console.WriteLine("Quel est ton nom ? ");
            Console.WriteLine(string.Empty);
            string inputname = Console.ReadLine();
            Console.WriteLine(string.Empty);
            Console.WriteLine("Quel est ton poids ? ");
            Console.WriteLine(string.Empty);
            float inputweight = float.Parse(Console.ReadLine());
            Console.WriteLine(string.Empty);
            var User = new User
            {
                name = inputname,
                weight = inputweight,
                date = DateTime.Today
            };
            Console.WriteLine(value: User.name);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(value: User.date.ToString("d"));
            Console.WriteLine(string.Empty);
            Console.WriteLine(value: User.weight);
        }
    }
}
