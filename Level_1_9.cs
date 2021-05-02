using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Level_1_9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] a = new string[] { "abcd", "abce", "cdx" };
        string[] s = new string[] { };

        s = solution(a, 2);
        for (int i = 0; i < a.Length; i++)
        {
            Debug.Log(i+" >>>>>>>>>>>>>>>> " +s[i]);
           
        }
    }

    //strings는 글자 배열을 받아 올 인자입니다
    //n보다 배열의 크기가 작을 순 없습니다 
    public string[] solution(string[] strings, int n)
    {
        string[] answer = new string[] { };
        for (int i = 0; i < strings.Length; i++)
        {
            for (int j = i+1; j < strings.Length; j++)
            {
                char a = strings[i][n];
                char b = strings[j][n];

                if(b<a)
                {
                    string h = strings[j];
                    strings[j] = strings[i];
                    strings[i] = h;
                }
                else if(b == a)
                {
                    string[] _str = new string[2];

                    _str[0] = strings[i];
                    _str[1] = strings[j];

                    Array.Sort(_str);
                    strings[i] = _str[0];
                    strings[j] = _str[1];

                }
            }
            //Debug.Log("인덱스 글자입니다" + a);
        }

        //Array.Sort(strings);
        answer = strings;

        return answer;
    }

}
