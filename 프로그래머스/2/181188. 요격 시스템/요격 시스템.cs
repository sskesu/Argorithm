using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] targets) {
        int answer = 0;
        List<(int s, int e)> targetsList = new List<(int, int)>();
        
        for (int i = 0; i < targets.GetLength(0); i++)
        {
            targetsList.Add((targets[i, 0], targets[i, 1]));
        }
        //정렬
        targetsList = targetsList.OrderBy(t => t.s).ToList();
        int end = int.MaxValue;
        
        foreach (var item in targetsList)
        {
            if (item.e < end)
            {
                end = item.e;
                continue;
            }
            if (item.s >= end)
            {
                answer++;
                end = item.e;
            }
        }
        return answer + 1;
    }
}