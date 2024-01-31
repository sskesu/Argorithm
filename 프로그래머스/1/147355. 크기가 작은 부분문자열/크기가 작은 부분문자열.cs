using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        for (int i = 0; i < t.Length - p.Length + 1; i++){
            if (Convert.ToInt64(t.Substring(i, p.Length)) <= Convert.ToInt64(p))
                answer++;
        }
        return answer;
    }
}