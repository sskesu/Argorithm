using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        float sum = 0;
        foreach (var n in numbers)
        {
            sum += n;
        }
        answer = sum / numbers.Length;
        return answer;
    }
}