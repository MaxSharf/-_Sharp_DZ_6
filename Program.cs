using System;

namespace С_Sharp_DZ_6
{
    class Program
    {
        static Random random = new Random();

        static void Main()
        {

            Prog1();
            Console.ReadKey(true);
        }

        public static void Fill(int[] arr, int min, int max = int.MaxValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }
        }

        static void Prog1()
        {
            Array ar1 = new Array();
            ar1.size = 5;
            ar1.array
        }

    }
}
