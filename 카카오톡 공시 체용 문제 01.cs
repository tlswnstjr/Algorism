using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kakaTest : MonoBehaviour
{
    //이 스크립트는 카카오톡 난이도 하 문제인 사각형의 지도 암호 문제를 풀어볼 스크립트입니다
    public int nSide;

    public int[] arr1 = new int[] { };

    public int[] arr2 = new int[] { };

    string[] firatSum1 = new string[] { };
    string[] firatSum2 = new string[] { };

    public string[] arr1AndArr2;

    int ar1j = 0;
    int ar2j = 0;
    private void Start()
    {
        arr1AndArr2 = new string[nSide];
        firatSum1 = new string[nSide];
        firatSum2 = new string[nSide];
        sss();
        for (int i = 0; i < nSide; i++)
        {
            Arr1OFArr2Bit(i);
            Arr1ORArr2(i);
            sss();
        }
        
    }
    //이 함수는 매번 값을 다시 초기화 작업을 해줍니다
    void sss()
    {
        for (int i = 0; i < nSide; i++)
        {
            firatSum1[i] = 0.ToString();
            firatSum2[i] = 0.ToString();
        }
        ar1j = 0;
        ar2j = 0;
    }

    //여기서 할당 받은 값을 2진법으로 변환합니다
    void Arr1OFArr2Bit(int i)
    {
        while (arr1[i] >= 2)
        {
            firatSum1[4 - ar1j] = (arr1[i] % 2).ToString();
            arr1[i] /= 2;
            ar1j++;
        }
        firatSum1[4 - ar1j] = arr1[0].ToString();
        while (arr2[i] >= 2)
        {
            firatSum2[4 - ar2j] = (arr2[i] % 2).ToString();
            arr2[i] /= 2;
            ar2j++;
        }
        firatSum2[4 - ar2j] = arr2[0].ToString();
    }

    //여기서 최종적으로 지도를 그려줍니다
    void Arr1ORArr2(int a)
    {
        for(int i = 0;i < nSide; i++)
        {
            int x = int.Parse(firatSum1[i]) | int.Parse(firatSum2[i]);
            if(x != 1)
            {
                arr1AndArr2[a] += "  ";
            }
            else
            {
                arr1AndArr2[a] += "#";

            }

        }
    }
}
