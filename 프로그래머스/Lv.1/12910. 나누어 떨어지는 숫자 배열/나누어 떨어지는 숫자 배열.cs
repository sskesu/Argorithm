using System;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[arr.Length];
        Array.Sort(arr);
        int index = 0;
        foreach (var n in arr)
        {
            if (n % divisor == 0)
            {
                answer[index++] = n;
            }
        }
        
        Array.Resize(ref answer, index);
        if (answer.Length == 0)
        {
            Array.Resize(ref answer, 1);
            answer[0] = -1;
        }
        return answer;
    }
}