using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab290621
{
    class Task
    {
        public int[] GetMergeArray(int[] arrOne, int[] arrTwo)
        {
            var temp = new List<int>(arrOne.ToList());
            var tmp = new List<int>(arrTwo.ToList());
            foreach (var i in tmp)
            { 
                if(temp.Contains(i))
                {
                    temp.Remove(i);
                }
                else
                {
                    temp.Add(i);
                }
            }
            return temp.ToArray();
        }

        public int GetSum(int[] arr) 
        {
            int sum = 0;            
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public int GetCount(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=0; j<arr.Length; j++)
                if (i>j && arr.Length >= 1)
                {
                    if ((arr[i] - arr[j]) == 0 || (arr[i] + arr[j]) == 0)
                    {
                        Console.WriteLine($"ind i{i} = {arr[i]} ind last{j} = {arr[j]}");

                        count++;
                    }
                }
            }             
            return count;
        }
    }
}
