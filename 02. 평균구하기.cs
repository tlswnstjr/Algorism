using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public double solution(int[] arr)
        {
            List<double> arr2 = new List<double>();
            for(int i = 0; i < arr.Length; i++)
            {
                arr2.Add(arr[i]);
            }
            double sum = 0;
            for(int i = 0; i < arr2.Count; i++)
            {
                sum += arr2[i];
            }
            double answer = sum / arr2.Count;
            return answer;
        }
    }
}
