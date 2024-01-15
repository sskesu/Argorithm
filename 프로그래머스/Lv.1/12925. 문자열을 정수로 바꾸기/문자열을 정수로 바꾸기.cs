using System;
public class Solution {
    public int solution(string s) {
        if (s[0] == '-')
        {
            return - Convert.ToInt16(s.Substring(1));
        }
        else if (s[0] == '+')
        {
            return Convert.ToInt16(s.Substring(1));
        }
        else 
        {
            return Convert.ToInt16(s);
        }
    }
}