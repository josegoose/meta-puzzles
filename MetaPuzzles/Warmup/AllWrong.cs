using System.Text.RegularExpressions;

namespace MetaPuzzles.Warmup
{
    internal class AllWrong
    {
        public static string getWrongAnswers(int N, string C)
        {
            if (!IsNumberWithingRange(N))
            {
                throw new MetaPuzzleException("First argument must be between 1 and 100.");
            }
            if (N != C.Length)
            {
                throw new MetaPuzzleException("First argument must match the second argument lenght.");
            }
            if (IsStringUsingOtherCharactersThanAorB(C))
            {
                throw new MetaPuzzleException("The second argument must only contain 'A' or 'B' characters.");
            }

            return FlipABCharacters(C);
        }

        private static string FlipABCharacters(string value)
        {
            string val = value.Replace('A', 'C');
            val = val.Replace('B', 'A');
            val = val.Replace('C', 'B');
            return val;
        }

        private static bool IsStringUsingOtherCharactersThanAorB(string value)
        {
            Regex containsOtherCharacterThanAorB = new Regex(@"[^AB]");
            return containsOtherCharacterThanAorB.IsMatch(value);
        }

        private static bool IsNumberWithingRange(int value)
        {
            return value >= 1 && value <= 100;
        }
    }
}


