using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Solution
    {
        public int[] solution(int[] arr)
        {

            int min = 1000;
            int ind = 0;
            int[] answer = new int[] { };
            List<int> arr2 = new List<int>();

            if (arr.Length == 1)
            {
                arr2.Add(-1);
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr2.Add(arr[i]);
                }


                for (int i = 0; i < arr2.Count; i++)
                {
                    if (arr2[i] < min)
                    {
                        min = arr2[i];
                        ind = i;
                    }
                }
                arr2.RemoveAt(ind);
            }

            answer = arr2.ToArray();

            return answer;
        }
    }
}
