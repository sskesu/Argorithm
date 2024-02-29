using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        bool[] nums = new bool[n];
        
        foreach (var item in section)
        {
            int index = item - 1;
            if (!nums[index])
            {
                for (int i = index; i < index + m; i++)
                {
                    if (i >= n)
                        break;
                    nums[i] = true;
                }
                answer++;
            }
        }
        return answer;
    }
}