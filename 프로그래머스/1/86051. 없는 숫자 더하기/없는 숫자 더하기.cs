using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for (int i = 0; i <= 9; i++)
        {
            foreach (var n in numbers)
            {
                if (n == i)
                {
                    answer -= n;
                }
            }
            answer += i;
        }
        return answer;
    }
}