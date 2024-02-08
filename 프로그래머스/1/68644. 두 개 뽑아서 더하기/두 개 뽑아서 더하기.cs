using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        SortedSet<int> hash = new SortedSet<int>();

        for (int i= 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                hash.Add(numbers[i] + numbers[j]);
            }
        }
        
        int[] answer = new int[hash.Count];
        
        int index = 0;
        foreach (int i in hash)
        {
            answer[index++] = i;
        }
        return answer;
    }
}