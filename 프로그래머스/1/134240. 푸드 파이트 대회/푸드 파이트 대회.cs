using System;

public class Solution {
    public string solution(int[] food) {
        string front = "";
        string back = "";
        for (int i = 1; i < food.Length; i++){
            if (food[i] >= 2)
            {
                for (int j = 0; j < food[i] / 2; j++)
                {
                    front += i.ToString();
                    back = i.ToString() + back;
                }
            }
        }
        
        
        return front + "0" + back;
    }
}