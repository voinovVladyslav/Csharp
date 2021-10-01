using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGame
{
    class Game
    {
        private int answer;
        private int attempts;
        Random rnd = new Random();
        
        public int Answer { get; set; }
        public int Attempts { get; set; }
        public Game() { answer = rnd.Next(1,11); attempts = 3; }
        public Game(int x): this() { attempts = x; } 

        public int Guess(int x) 
        {
            if (x > 10 | x < 1)
                return 5;
            if (x == answer)
                return 1;
            if (x < answer & attempts > 0)
                return 2;
            if (x > answer & attempts > 0)
                return 3;
            if (x != answer & attempts == 0)
                return 4;
            
            return 0;
        }
        
        public void Loop(int x) 
        {
            this.attempts--;
            switch (this.Guess(x))
            {
                case 1:
                    Console.WriteLine("You win!");
                    this.attempts = 0;
                    break;
                case 2:
                    Console.WriteLine("Higher");
                    break;
                case 3:
                    Console.WriteLine("Lower");
                    break;
                case 4:
                    Console.WriteLine("You lose!\nAnswer is " + answer);
                    break;
                case 5:
                    Console.WriteLine("Number isn`t in range 1-10");
                    break;
            }
            
        }
        
        public void Play() 
        {
            while (attempts > 0) 
            {
                Console.WriteLine("Guess the number in range 1 - 10.");
                int x = int.Parse(Console.ReadLine());
                this.Loop(x);
            }
        }
    }
}
