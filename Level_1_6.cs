using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//이 스크립트는 프로그래머스 레벨 1 복권 알고리즘입니다 
public class Level_1_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] b = new int[] { 31, 10, 45, 1, 6, 19 };


        Debug.Log(solution(a, b));
    }

    public  int[] a = new int[] { 44, 1, 0, 0, 31, 25 };
    public int[] _a;
    public int[] _aa;

    public int[] solution(int[] lottos, int[] win_nums)
    {
        //for (int i = 0; i < lottos.Length; i++)
        //{
        //    Debug.Log(lottos[i]);
        //}
        //Debug.Log("");
        //Debug.Log("");
        //Debug.Log("");
        //Debug.Log("시작 배열의 값" lottos);
        int[] answer = new int[2] {0, 0 };

        answer[0] = _aaa(lottos, win_nums);

        answer[1] = _bbb(lottos, win_nums);

        Debug.Log(answer[0]);
        Debug.Log(answer[1]);


        return answer;
    }

    int _aaa(int[] lottos, int[] win_nums)
    {
        int a = 0;

       _a = lottos;
       _aa = _a;

        for (int i = 0; i < _a.Length; i++)
        {
            //Debug.Log(_b[i]);

            if (lottos[i] == 0)
            {
                Debug.Log("11111111111111111배열 a 의 인덱스 값입니다 " + _aa[i]);

                _aa[i] = win_nums[i];

                Debug.Log("22222222222222222222배열 a 의 인덱스 값입니다 " + _aa[i]);

            }

            for (int j = 0; j < win_nums.Length; j++)
            {
                if (_aa[i] == win_nums[j])
                {
                    //Debug.Log("i 의 인덱스 값입니다 " + i);

                    Debug.Log("배열 a 의 인덱스 값입니다 " + _aa[i]);
                    a++;
                }
            }

            //Debug.Log("b >>>>>>>>" + a);

        }
        //lottos = _aa;
        return a;
    }





    int _bbb(int[] lottos, int[] win_nums)
    {
        int b = 0;

        int[] _b = lottos;

        for (int i = 0; i < _b.Length; i++)
        {
            //Debug.Log(_b[i]);

            if (lottos[i] == 0)
            {
                Debug.Log("11111111111111111배열 b 의 인덱스 값입니다 " + _b[i]);

                _b[i] = win_nums[i] + 1;

                Debug.Log("22222222222222222222배열 b 의 인덱스 값입니다 " + _b[i]);

            }

            for (int j = 0; j < win_nums.Length; j++)
            {
                if (_b[i] == win_nums[j])
                {
                    //Debug.Log("i 의 인덱스 값입니다 " + i);

                    Debug.Log("배열 b 의 인덱스 값입니다 " + _b[i]);
                    b++;
                }
            }

            //Debug.Log("b >>>>>>>>" + b);

        }
        return b;

    }
}
