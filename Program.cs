using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        private const int MIN_DICE_ROLL = 1;
        private const int MAX_DICE_ROLL = 6;

        static void Main(string[] args)
        {
            RollDice();
        }

        private static void RollDice()
        {
            var random = new Random();
            for (int index = 0; index < 100; index++)
            {
                int diceRoll = RollDice(random);
                if (diceRoll == RollDice(random))
                {
                    Console.WriteLine(string.Format("Sequence: {0}; Dice Roll: {1}", index, diceRoll));
                }
            }
            Console.ReadKey();
        }

        private static int RollDice(Random randomGenerator)
        {
            return randomGenerator.Next(MIN_DICE_ROLL, MAX_DICE_ROLL + 1);
        }
    }
}
