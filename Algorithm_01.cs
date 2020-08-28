using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm_01 : MonoBehaviour
{
    //한 사람당 가위 바위 보중 하나를 낼 수 있습니다
    int n = 100;
    //다음 중 승리 조건은 가위 바위 보 이 세가지중 가장 많은 비율을 차지하고 있는 것이 승리합니다

    //두가지 이상이 같은 수일 때는 무승부로 종료 됩니다

    //한번에 승리가 나는 경우의 수를 구하시오 

    //input값은 6명입니다 


    List<int> arr = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        for(rock = 0; rock <= n; rock++)
            for(s = 0; s <= n - rock; s++)
            {
                pop = n - rock - s;
                if (rock > s)
                {
                    if(rock != pop)
                    cut++;
                }
                else if (rock < s)
                {
                    if (s != pop)
                    {
                        cut++;
                    }

                }
                    else
                {
                    if (rock < pop)
                    {
                        cut++;
                    }
                }

                print(cut);
            }
       
    }
    int rock;
    int s;
    int pop;
    int cut = 0;
    // Update is called once per frame
    void Update()
    {
        
    }
}
