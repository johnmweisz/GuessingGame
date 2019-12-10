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

        }
    }

    public class Game
    {
        private static int answer;
        public static void ChooseAnswer(int low, int high)
        {
            Random random = new Random();
            answer = random.Next(low, high);
        }

        public static bool MakeGuess(int guess)
        {

        }
    }

}
