using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Algorism : MonoBehaviour
{
    //이 변수는 외부에서 값을 지정해줍니다
    public long a, b;

    long sum;
   
    // Start is called before the first frame update
    void Start()
    {
        solution((int)a, (int)b);
    }
        long  answer = 0;
    long  solution(int a, int b)
    {
        if(a < b)
        {
            for (long i = a; i <= b; i++)
            {
                answer += i;
            }
        }
        else if(a >= b)
        {
            for (long i = a; i >= b; i--)
            {
                answer += i;
            }
        }        
        return answer;
    }
}


