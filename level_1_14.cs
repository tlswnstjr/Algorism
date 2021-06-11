using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class level_1_14 : MonoBehaviour
{
    string[] sss = { "asdf", "fawe", "Kim" };

    // Start is called before the first frame update
    void Start()
    {
        string st = solution(sss, "Kim");
        Debug.Log( st);
    }

    public string solution(string[] seoul, string name)
    {
        string answer = "";

        for (int i = 0; i < seoul.Length; i++)
        {
            if(seoul[i] == name)
            {
                answer = $"김서방은 {i}에 있다";
            }
        }

        return answer;
    }
}
