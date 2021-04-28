using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Level_1_7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int s = 45;
        //string a = Convert.ToString(s, 3);

        //Debug.Log(a);
        solutions();
    }

    public int[] _n;

   void solutions()
    {
        int n = 45;
        int sum = 0;
        _n = new int[30];
        int t = 0;
        while (n != 1)
        {
            _n[t] = (int)(n % 3);
            n /= 3;
            t++;
        }
        _n[t] = n;
        t++;
        for (int i = 0; i < t; i++)
        {
            int pow = (int)Math.Pow(3, i);

            //Debug.Log(_n[t - 1 - i]);
            sum += pow * _n[t-1 -i];

        }

    }















    public int solution(int n)
    {
        int t = 0;
        int answer = 0;

        int[] _n = new int[30];
        while (n != 1)
        {
            _n[t] = (int)(n % 3);
            n /= 3;
            t++;
        }
        _n[t] = n;
        t++;
        for (int i = 0; i < t; i++)
        {
            int pow = (int)Math.Pow(3, i);


            answer += pow * _n[t - 1 - i];

        }
        return answer;
    }
}
