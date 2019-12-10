using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.ChooseAnswer(1, 11);
            while (true)
            {
                Console.WriteLine(@"Make a guess or 'exit'");
                var input = Console.ReadLine();
                if (input == "exit") break;
                if(Game.MakeGuess(Convert.ToInt32(input))) break;
            }
            Console.WriteLine("The answer was " + Game.ShowAnswer());
        }
    }

    public class Game
    {
        private static int _answer;
        public static void ChooseAnswer(int low, int high)
        {
            var random = new Random();
            _answer = random.Next(low, high);
        }

        public static bool MakeGuess(int guess)
        {
            return guess == _answer;
        }
        public static int ShowAnswer()
        {
            return _answer;
        }
    }

}
