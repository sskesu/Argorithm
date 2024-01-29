using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] words = s.Split(' ');
        List<string> answers = new List<string>();
        
        string str;
        foreach (var item in words){
            str = "";
            for (int i = 0; i < item.Length; i++){
                if (i % 2 == 0)
                {
                    str += item.Substring(i, 1).ToUpper();
                }
                else
                {
                    str += item.Substring(i, 1).ToLower();
                }
            }
            answers.Add(str);
        }
        answer = string.Join(" ", answers);
        return answer;
    }
}