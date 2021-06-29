using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab290621
{
    class Task
    {
        public int[] GetMergeArray(int[] arrOne, int[] arrTwo) => arrOne.Union(arrTwo).ToArray();

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
            for(int i = 0; i<arr.Length; i++)
            {
                for (int j = 0+i; j < arr.Length; j++)
                {
                    if (j>i && arr[i] - arr[j] == 0 || arr[i] + arr[j] == 0) 
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
