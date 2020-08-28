using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public class Solution
//{
//    public long solution(long n)
//    {
//        //일단 리스트 하나를 새로 만둘어주고 거기에 n값을 string형식으로 넣어줍니다 
//        List<string> x = new List<string>();
//           x.Add(n.ToString());
//        //char xx;


//        //for (int i = 0; i < x.Length - 1; i++)
//        //{
//        //    if (x[i] < x[i + 1])
//        //    {
//        //        xx = x[i + 1];
//        //        //x[i + 1] = x[i];
//        //        //x[i] = xx;
//        //    }
//        //}
//        long answer = int.Parse(x.Sort(x[0])); 
//        return answer;
//    }
//}
public class Solution
{
    public long solution(long n)
    {
        List<int> list = new List<int>();
        string a = n.ToString();
        for (int i = 0; i < a.Length; i++)
        {
            list.Add(int.Parse(a[i].ToString()));
        }
        
        for(int i = 0; i< list.Count-1; i ++)
        {
            for(int j = i +1; j< list.Count; j++)
            {
                if (list[i] < list[j])
                {
                    int x = list[i];
                    list[i] = list[j];
                    list[j] = x;
                }
            }          
        }
        a = string.Empty;

        for(int i = 0; i < list.Count; i++)
        {
            a += list[i];
        }
        long answer = long.Parse(a);

        return answer;
    }
}