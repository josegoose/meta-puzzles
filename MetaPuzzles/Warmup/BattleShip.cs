using System.Linq;

namespace MetaPuzzles.Warmup
{
    internal class BattleShip
    {
        public static double getHitProbability(int R, int C, int[,] G)
        {
            if (!IsNumberWithingRange(R))
            {
                throw new MetaPuzzleException("First argument must be between 1 and 100.");
            }
            if (!IsNumberWithingRange(C))
            {
                throw new MetaPuzzleException("Second argument must be between 1 and 100.");
            }
            if (!HasMatrixExpectedRows(R, G))
            {
                throw new MetaPuzzleException("Third argument rows must match first argument value.");
            }
            if (!HasMatrixExpectedColumns(C, G))
            {
                throw new MetaPuzzleException("Third argument columns must match second argument value.");
            }
            if (HasMatrixAnyValueDifferentThan1And0(G))
            {
                throw new MetaPuzzleException("The third argument must only contains 0 or 1.");
            }

            return (double)G.Cast<int>().Sum() / (double)(R*C);
        }

        private static bool HasMatrixExpectedRows(int R, int[,] G)
        {
            return R == G.GetLength(0);
        }

        private static bool HasMatrixExpectedColumns(int C, int[,] G)
        {
            return C == G.GetLength(1);
        }

        private static bool HasMatrixAnyValueDifferentThan1And0(int[,] G)
        {
            return G.Cast<int>().Any(x => x > 1 || x < 0);
        }

        private static bool IsNumberWithingRange(int value)
        {
            return value >= 1 && value <= 100;
        }
    }
}


