using System;

public class Solution {
    public int solution(string s) {
        char x;
        int xCount = 0;
        int otherCount = 0;
        
        int answer = 0;
        
        x = s[0];
        xCount++;
        s = s.Substring(1);
        
        while (true)
        {
            if (s.Length == 0)
            {
                answer++;
                break;
            }
        
            if (x == s[0])
                xCount++;
            else
                otherCount++;
        
            s = s.Substring(1);
        
            if (xCount == otherCount)
            {
                answer++;
                if (s.Length > 0)
                {
                    x = s[0];
                    s = s.Substring(1);
                    xCount = 1;
                    otherCount = 0;
                }
                else
                {
                    break;
                }
            }
        
        }
        
        return answer;
    }
}