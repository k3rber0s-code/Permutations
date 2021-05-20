using System;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2 };
            int[] firstPermutation = { 1, 2, 0 };
            var c1 = (ComputePermutation(numbers, firstPermutation));
            var c2 = (ComputePermutation(c1, firstPermutation));
            var c3 = (ComputePermutation(c2, firstPermutation));
            foreach (int c in c1)
            {
            Console.WriteLine(c);

            }
            foreach (int c in c2)
            {
                Console.WriteLine(c);

            }

            Console.WriteLine(FindPermutationIndentity(numbers, firstPermutation));



        }
        public static int FindPermutationIndentity(int[] numbers, int[] permutation)
        {
            int stepCounter = 2;
            var temp = ComputePermutation(numbers, permutation);
            while (temp != numbers)
            {
                stepCounter += 1;
                var v = ComputePermutation(temp, permutation);
                temp = v;
            }
            return stepCounter;
            

        }

        public static int[] ComputePermutation( int[] numbers, int[] permutation)
        {
            int[] permutedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                permutedNumbers[i] = permutation[numbers[i]];
            }
            return permutedNumbers;
        }
        public static int LeastCommonMultiple(int a, int b)
        {
            return (a * b) / GreatestCommonDivisor(a, b);
        }

        private static int GreatestCommonDivisor(int a, int b)
        {

            if (b == 0)
            {
                return a;
            }
            else
            {
                return GreatestCommonDivisor(b, a % b);
            }
        }
    }
}
