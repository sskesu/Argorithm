using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> ints = new List<int>();
        for (int i = 0; i < score.Length; i++)
        {
            ints.Add(score[i]);
            ints.Sort();
            if(ints.Count > k)
            {
                ints.RemoveAt(0);
            }
            answer[i] = ints[0];
        }
        return answer;
    }
}