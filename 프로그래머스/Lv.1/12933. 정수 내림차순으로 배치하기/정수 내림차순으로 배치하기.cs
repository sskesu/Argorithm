using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        string[] arr = new string[Convert.ToString(n).Length];
        for (int i = 0; i < Convert.ToString(n).Length; i++)
        {
            string str = Convert.ToString(n).Substring(i, 1);
            arr[i] = str;
        }
        Array.Sort(arr);
        Array.Reverse(arr);
        answer = Convert.ToInt64(string.Join("", arr));
        return answer;
    }
}