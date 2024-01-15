using System;
public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[Convert.ToString(n).Length];
        for (int i = 0; i < Convert.ToString(n).Length; i++)
        {
            string str = Convert.ToString(n).Substring(i, 1);
            answer[i] = Convert.ToInt32(str);
        }
        Array.Reverse(answer);
        return answer;
    }
}