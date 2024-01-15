using System;
public class Solution {
    public long solution(long n) {
        int num = (int)Math.Sqrt(n);
        if (Math.Pow(num, 2) == n)
        {
            return (long)Math.Pow(num + 1, 2);
        }
        return -1;
    }
}