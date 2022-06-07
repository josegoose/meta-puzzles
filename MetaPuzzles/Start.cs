using MetaPuzzles.Warmup;
using System;

namespace MetaPuzzles
{
    internal class Start
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Warmup - AllWrong: (OK) " + AllWrong.getWrongAnswers(3, "AAA"));
            }
            catch (MetaPuzzleException e)
            {
                Console.WriteLine("Warmup - AllWrong: (ERROR) " + e.Message);
            }

            int[,] G = { { 0, 0 }, { 0, 1 }, { 1, 1 }, { 1, 1 } };
            try
            {
                Console.WriteLine("Warmup - BattleShip: (OK) " + BattleShip.getHitProbability(4, 2, G));
            }
            catch (MetaPuzzleException e)
            {
                Console.WriteLine("Warmup - BattleShip: (ERROR) " + e.Message);
            }
        }
    }
}


