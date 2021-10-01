using System;

namespace NumberGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Chose difficulty:\n" +
                "1. Hard\n" +
                "2. Medium\n" +
                "3. Easy");
            int x = int.Parse(Console.ReadLine());
            Game game = new Game(x);
            game.Play();
        }
    }
}
