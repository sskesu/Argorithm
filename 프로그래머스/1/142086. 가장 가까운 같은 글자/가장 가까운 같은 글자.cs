using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        Dictionary<char, int> charDictionarty = new Dictionary<char, int>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (charDictionarty.ContainsKey(s[i]))
            {
                answer[i] = i - charDictionarty[s[i]];
                charDictionarty[s[i]] = i;
            }
            else
            {
                answer[i] = -1;
                charDictionarty.Add(s[i], i);
            }
        }
        return answer;
    }
}