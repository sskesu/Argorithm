using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        while(n >= 3)
        {
            list.Add(n % 3);
            n = n / 3;
        }
        list.Add(n);
        list.Reverse();
        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i] * (int)Math.Pow(3, i);
        }
        return answer;
    }
}