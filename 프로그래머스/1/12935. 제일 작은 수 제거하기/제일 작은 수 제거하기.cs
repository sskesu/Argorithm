using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = arr.ToArray();
        if (arr.Length == 1) 
            return new int[] {-1};
        else
        {
            Array.Sort(answer);
            int[] arr2 = new int[1] { answer[0] };
            answer = arr.Except(arr2).ToArray();
        }
        return answer;
    }
}