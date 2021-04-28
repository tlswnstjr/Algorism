using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Level_1_4 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        int[] _a = new int[] { 2, 2, 3, 3 };
        //_a.Sort();
        int _b = 10;
        Debug.Log(solution(_a, _b));
    }
    public int solution(int[] d, int budget)
    {
        int answer = 0;

        Array.Sort(d);

        //0으로 초기화 해줍니다 
        int s = 0;
        int _ans = 0;
        for (int i = 0; i < d.Length; i++)
        {
            s += d[i];

            if (s < budget)
            {
                answer++;
            }
        }
        return answer;
    }
}
