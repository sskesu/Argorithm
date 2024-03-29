using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];

        for (int i = 0; i < X.Length; i++)
        {
            arr1[Convert.ToInt16(X.Substring(i, 1))]++;
        }
        for (int i = 0; i < Y.Length; i++)
        {
            arr2[Convert.ToInt16(Y.Substring(i, 1))]++;
        }
        
        StringBuilder sb = new StringBuilder();
        
        for (int i = 9; i >= 0; i--){
            if (arr1[i] == 0 || arr2[i] == 0)
                continue;
            
            int min = Math.Min(arr1[i], arr2[i]);
            
            for (int j = 0; j < min; j++)
            {
                sb.Append(i);
            }
        }
        
        answer = sb.ToString();
        
        if (answer == "")
            return "-1";
        else if (answer[0] == '0')
            return "0";
        return answer;
    }
}