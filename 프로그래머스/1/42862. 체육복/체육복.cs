using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        List<int> list = reserve.ToList();
        
        for (int i = 1; i<= n; i++)
        {
            if (lost.Contains(i))
            {
                if (list.Contains(i - 1) && !lost.Contains(i - 1))
                {
                    list.Remove(i - 1);
                    answer++;
                }
                else if (list.Contains(i))
                {
                    list.Remove(i);
                    answer++;
                }
                else if (list.Contains(i + 1) && !lost.Contains(i + 1))
                {
                    list.Remove(i + 1);
                    answer++;
                }
            }
            else
            {
                answer++;
            }
        }
        return answer;
    }
}