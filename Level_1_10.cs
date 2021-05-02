using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1_10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(solution("Zbcdefg"));
    }

    public char[] _ans;
    public string solution(string s)
    {
        string answer = "";

        char[] _ans = new char[s.Length];

        for (int i = 0; i < _ans.Length; i++)
        {
            _ans[i] = s[i];
        }
        for (int i = 0; i < _ans.Length; i++)
        {
            for (int j = i+1; j < _ans.Length; j++)
            {
                char ch = ' ';
                if(_ans[i] < _ans[j])
                {
                    ch = _ans[i];
                    _ans[i] = _ans[j];
                    _ans[j] = ch;
                }          
            }
            answer += _ans[i];
        }


        return answer;
    }
}
