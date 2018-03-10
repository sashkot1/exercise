using System;
using System.Linq;
namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse)
                .ToArray();

            long checkNumber = long.Parse(Console.ReadLine());
            long[] reversedArray = array.Reverse().ToArray();

            int counter = 0;
            long verifier = 0;
            for (int i = 0; i < reversedArray.Length; i++)
            {

                counter++;
                long curentNumber = reversedArray[i];
                if (curentNumber == checkNumber)
                {
                    verifier++;
                    break;
                }

            }

            if (verifier == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else if (verifier >= 1)
            {
                long[] arrayToEvaluate = reversedArray.Skip(counter)
                .Take(reversedArray.Length).ToArray();

                long result = arrayToEvaluate.Sum();
                Console.WriteLine(result);
            }






        }
    }
}
