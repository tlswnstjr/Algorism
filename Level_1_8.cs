using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1_8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] a = new int[] { 4, 7, 12 };
        bool[] s = new bool[] { true, false, true };
        Debug.Log(solution(a, s));
    }

    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0;
        for (int i = 0; i < signs.Length; i++)
        {
            if(signs[i] == true)
            {
                answer += absolutes[i]; 
            }
            else
            {
                answer += -absolutes[i];

            }
        }

        return answer;
    }
}
