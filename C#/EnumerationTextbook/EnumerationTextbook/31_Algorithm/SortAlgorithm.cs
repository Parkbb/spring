using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class SortAlgorithm
    {
        static void Main(string[] args)
        {
            // 정렬 알고리즘

            //[1] Input
            int[] data  = { 3, 2, 1, 5, 4};

            //[2] Process
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            Console.WriteLine(data.ToString());

          
        }
    }
}
