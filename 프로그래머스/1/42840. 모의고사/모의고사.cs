using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] num1 = new int[] { 1, 2, 3, 4, 5 };
        int[] num2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] num3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        
        Dictionary<int, int[]> dic = new Dictionary<int, int[]>()
        {
            {0, num1},
            {1, num2},
            {2, num3},
        };
        
        int[] corrCount = new int[dic.Count];
        
        for (int i = 0; i < dic.Count; i++)
        {
            for (int j = 0; j < answers.Length; j++)
            {
                if (dic[i][j % dic[i].Length] == answers[j])
                {
                    corrCount[i]++;
                }
            }
        }
        
        int max = corrCount.Max();
        
        for (int i = 0; i < corrCount.Length; i++)
        {
            if (corrCount[i] != max)
            {
                dic.Remove(i);
            }
        }
        
        int[] answer = new int[dic.Count];
        int index = 0;
        
        foreach (var item in dic)
        {
            answer[index++] = item.Key + 1;
        }
        return answer;
    }
}