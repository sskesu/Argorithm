using System;

public class Solution {
    public int solution(string s) {
        string answer = "";
        for (int i = 0; i < s.Length; i++)
        {
            int a;
            if (int.TryParse(s.Substring(i, 1), out a))
            {
                answer += s.Substring(i, 1);
                continue;
            }
            switch (s.Substring(i, 3))
            {
                case "one":
                    answer += "1";
                    i += 2;
                    continue;
                case "two":
                    answer += "2";
                    i += 2;
                    continue;
                case "six":
                    answer += "6";
                    i += 2;
                    continue;
                default:
                    break;
            }
            switch (s.Substring(i, 4))
            {
                case "zero":
                    answer += "0";
                    i += 3;
                    continue;
                case "four":
                    answer += "4";
                    i += 3;
                    continue;
                case "five":
                    answer += "5";
                    i += 3;
                    continue;
                case "nine":
                    answer += "9";
                    i += 3;
                    continue;
                default:
                    break;
            }
            switch (s.Substring(i, 5))
            {
                case "three":
                    answer += "3";
                    i += 4;
                    continue;
                case "seven":
                    answer += "7";
                    i += 4;
                    continue;
                case "eight":
                    answer += "8";
                    i += 4;
                    continue;
                default:
                    break;    
            }
        }
        return Convert.ToInt32(answer);
    }
}