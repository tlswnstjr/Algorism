using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] index = new int[] { 1, 2, 7, 6, 4 };

        Debug.Log(solution(index));
    }

    public int solution(int[] nums)
    {
        int answer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                for (int k = j+1; k < nums.Length; k++)
                {
                    int s = nums[i] + nums[j] + nums[k];

                    bool check = true;

                    for (int h = 2; h < s; h++)
                    {
                        if(s%h ==0)
                        {
                            check = false;
                            break;
                        }
                    }
                    if(check)
                    {
                        answer++;
                    }
                }
            }
        }
   
        return answer;
    }
}
