using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int bigX = 0;
        int bigY = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 0] < sizes[i, 1])
            {
                var temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }
            if (sizes[i, 0] > bigX)
            {
                bigX = sizes[i, 0];
            }
            if (sizes[i, 1] > bigY)
            {
                bigY = sizes[i, 1];
            }
        }
        answer = bigX * bigY;
        return answer;
    }
}