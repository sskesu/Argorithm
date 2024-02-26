using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        List<int> numList = new List<int>();
        int answer = 0;
    
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    numList.Add(nums[i] + nums[j] + nums[k]);
                }
            }
        }
        
        //numList = numList.Distinct().ToList();
        
        foreach (var item in numList)
        {
            for (int i = 2; i < item; i++)
            {
                if (item % i == 0)
                    break;
                if (i == item - 1)
                    answer++;
            }
        }
        
        return answer;
    }
}