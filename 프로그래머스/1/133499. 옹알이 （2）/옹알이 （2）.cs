using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] canBabbling = new string[] { "aya", "ye", "woo", "ma" };
        
        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < canBabbling.Length; j++)
            {
                babbling[i] = babbling[i].Replace(canBabbling[j] + canBabbling[j], "@");
                babbling[i] = babbling[i].Replace(canBabbling[j], " ");
            }
        
            if (babbling[i].Trim() == "")
                answer++;
        }

        return answer;
    }
}