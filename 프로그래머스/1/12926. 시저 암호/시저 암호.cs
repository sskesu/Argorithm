public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        foreach (char c in s)
        {
            if (c != ' ')
            {
                if (65 <= c && c <= 90 && 90 < c + n)
                {
                    answer += (char)(c - 26 + n);
                }
                else if (97 <= c && c <= 122 && 122 < c + n)
                {
                    answer += (char)(c - 26 + n);
                }
                else
                {
                    answer += (char)(c + n);
                }
            }
            else
            {
                answer += c;
            }
        }
        return answer;
    }
}