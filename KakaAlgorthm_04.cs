using System.Collections;
using System.Collections.Generic;
using UnityEngine;














public class KakaAlgorthm_04 : MonoBehaviour
{
    //이변수는 셔틀 버스가 몇 번 순환하는지 알려주는 변수입니다
    public int n;

    //다음 변수는 버스간격 시간입니다
    public int t;

    public List<string> m = new List<string>();
    //다음 변수는 이번 버스에 총 몇명의 크루가 탑승 가능하지 알려주는 변수입니다

    public int mm;


    //이 변수는 크루들의 데이터 테이블입니다
    public string[] timeTable;

    string[] cutTime;
    string[] cutTime2;
    //언제나 버스는 무조건 09:00시 부터 출발합니다
    string clock = "09";
    string minute = "00";


    int a = 0;
    int b = 0;

    string myTime = "09:00";
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i =0; i < n; i++)
        {
            for(int j =0; j< timeTable.Length; j++)
            {
                cutTime = timeTable[j].Split(':');
                if (timeTable[j] != " ")
                {
                    if (int.Parse(clock) > int.Parse(cutTime[0]))
                    {
                        m.Add(timeTable[j]);
                        //값이 입력된 아이를 구분하기 위한 수단입니다 
                        timeTable[j] = " ";
                    }
                    else if(int.Parse(clock) == int.Parse(cutTime[0]))
                    {
                        if(int.Parse(minute)>= int.Parse(cutTime[1]))
                        {
                            m.Add(timeTable[j]);
                            //값이 입력된 아이를 구분하기 위한 수단입니다 
                            timeTable[j] = " ";
                        }
                    }
                }
                else if(timeTable[j] == " ")
                {
                    continue;
                }
            }
            minute = (int.Parse(minute) + t).ToString();
            if(n != i+1)
            {
                m.Clear();
            }
        }






        if(mm != m.Count)
        {
            m.Add(myTime);
        }
        //만약 크루 자리가 다 찬다면 가장 늦게오는크루를 찾아야한다
        else if(mm == m.Count)
        {
            for(int i = 0; i < m.Count; i++)
            {

                cutTime2 = m[i].Split(':');
                if (int.Parse(cutTime2[0]) > a)
                {
                    a = int.Parse(cutTime2[0]);
                    b = int.Parse(cutTime2[1]);
                }
                else if (int.Parse(cutTime2[0]) == a)
                {
                    if ( int.Parse(cutTime2[1])>= b)
                    {
                        b = int.Parse(cutTime2[1]);
                    }
                }
            }
            myTime = cutTime2[0] + ':' + (b-1).ToString().PadLeft(2, '0');
        }
        print(myTime);
    }
}
