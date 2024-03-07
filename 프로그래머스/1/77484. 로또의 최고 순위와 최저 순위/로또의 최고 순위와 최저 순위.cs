using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];

        int count = 0;
        int unknown = 0;


        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                ++unknown;
            }
            else
            {
                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j])
                    {
                        ++count;
                        break;
                    }
                }
            }
        }
        
        switch (count)
        {
            case 2:
                answer[1] = 5;
                break;
            case 3:
                answer[1] = 4;
                break;
            case 4:
                answer[1] = 3;
                break;
            case 5:
                answer[1] = 2;
                break;
            case 6:
                answer[1] = 1;
                break;
            default:
                answer[1] = 6;
                break;
        }
        
        switch (count + unknown)
        {
            case 2:
                answer[0] = 5;
                break;
            case 3:
                answer[0] = 4;
                break;
            case 4:
                answer[0] = 3;
                break;
            case 5:
                answer[0] = 2;
                break;
            case 6:
                answer[0] = 1;
                break;
            default:
                answer[0] = 6;
                break;
        }
        return answer;
    }
}