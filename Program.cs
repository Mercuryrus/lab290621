using System;

namespace lab290621
{
    class Program
    {
        static void Main()
        {
            int[] arrOne = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrTwo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            int[] arrThree = new int[] { 0, 1, 0, 1, 0 };
            Console.WriteLine("ЁБАНЫЙ РОТ ЭТО КАЗИНО БЛЯТЬ!\n");
            Task Sol = new Task();
            foreach (int i in Sol.GetMergeArray(arrOne, arrTwo))
            {
                Console.Write($" |{i}|");
            }
            Console.WriteLine($"\n\n {Sol.GetSum(arrOne)}");
            Console.WriteLine($"\n {Sol.GetCount(arrThree)}");
        }
    }
}
