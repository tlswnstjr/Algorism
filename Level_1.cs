using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    private void Start()
    {
        //int[] a = new int[] { 2, 1, 3, 4, 1 };
        int[] a = new int[] { 1, 2, 3, 4 };
        int[] b = new int[] { -3, -1, 0, 2 };

        //solution(a);
        //Debug.Log(solution(a));

        Debug.Log(solution(a, b));
    }

    /// <summary>
    /// 글자 배열의 가운데 값을 찾은 함수입니다 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string solution(string s)
    {
        string answer = "";
        string name = "";
        name = s;

        if (s.Length%2== 0)
        {
            Debug.Log("짝수입니다");

        Debug.Log("글자 수 " + s.Length);
            int a = (s.Length / 2)-1;
            //여기로 들어온다는건 홀수라는 의미
            answer = name[a].ToString()+ name[a+1].ToString();
        }
        else
        {
            Debug.Log("홀수입니다");
            int a = s.Length / 2;

            //여기는 짝수라는 의미
            answer = name[a].ToString();
        }

        return answer;
    }

    /// <summary>
    /// 배열 안의 임이의 두 수의 합
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int[] solution(int[] numbers)
    {
        Debug.Log("여기는 배열 함수 안입니다");
        int[] answer = new int[] { };

        int s = 0;
        List<int> ans = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {

                s = numbers[i] + numbers[j];
                if(ans.Count ==0)
                {
                    ans.Add(s);

                }
                else
                {
                    for (int k = 0; k < ans.Count; k++)
                    {
                        if (ans[k] == s)
                        {
                            break;
                        }
                        else if (ans[k] != s && k + 1 == ans.Count)
                        {
                            ans.Add(s);
                        }
                    }
                }
               

            }
        }

        int jump= 0;
        for (int i = 0; i < ans.Count; i++)
        {
            for (int j = i+1; j < ans.Count; j++)
            {
                if(ans[i]> ans[j])
                {
                    jump = ans[j];
                    ans[j] = ans[i];
                    ans[i] = jump;
             
                }
            }
            ////Debug.Log("배열의 갯수 및 내용입니다>>>>>>>>>>" + ans[i]);

        }

        for (int i = 0; i < ans.Count; i++)
        {

            Debug.Log("배열의 갯수 및 내용입니다>>>>>>>>>>" + ans[i]);
        }
        answer = ans.ToArray();
        return answer;
    }


    //public int[] solution(int[] numbers)
    //{

    //    int[] answer = new int[] { };

    //    int s = 0;

    //    int indxe = 0;
    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        for (int j = i + 1; j < numbers.Length; j++)
    //        {
    //            s = numbers[i] + numbers[j];
    //            if (answer.Length == 0)
    //            {
    //                answer[indxe] = s;

    //            }
    //            else
    //            {
    //                for (int k = 0; k < answer.Length; k++)
    //                {
    //                    if (answer[k] == s)
    //                    {
    //                        break;
    //                    }
    //                    else if (answer[k] != s && k + 1 == answer.Length)
    //                    {
    //                        answer[indxe] = s;
    //                    }
    //                }
    //            }
    //            indxe++;


    //        }
    //    }

    //    int jump = 0;
    //    for (int i = 0; i < answer.Length; i++)
    //    {
    //        for (int j = i + 1; j < answer.Length; j++)
    //        {
    //            if (answer[i] > answer[j])
    //            {
    //                jump = answer[j];
    //                answer[j] = answer[i];
    //                answer[i] = jump;

    //            }
    //        }
    //        Debug.Log("배열의 갯수 및 내용입니다>>>>>>>>>>" + answer[i]);

    //    }

    //    for (int i = 0; i < answer.Length; i++)
    //    {

    //        Debug.Log("배열의 갯수 및 내용입니다>>>>>>>>>>" + answer[i]);

    //    }

    //    return answer;
    //}


    public int solution(int[] a, int[] b)
    {
        int answer = 1234567890;
        int s = 0;
        for (int i = 0; i < a.Length; i++)
        {
            s += a[i] * b[i];
        }

        answer =  s;
        return answer;
    }
}
