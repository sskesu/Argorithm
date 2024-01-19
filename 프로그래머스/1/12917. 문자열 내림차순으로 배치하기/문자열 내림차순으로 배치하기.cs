using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        List<string> list = new List<string>();
        List<string> listA = new List<string>();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.Parse(s.Substring(i, 1)) > 90)
            {
                list.Add(s.Substring(i, 1));
            }
            else
            {
                listA.Add(s.Substring(i, 1));
            }
        }
        
        list.Sort();
        list.Reverse();
        
        listA.Sort();
        listA.Reverse();
        
        foreach (var item in list)
        {
            answer += item;
        }
        foreach (var item in listA)
        {
            answer += item;
        }
        return answer;
    }
}