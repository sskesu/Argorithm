using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int[] ints = new int[commands[i, 1] + 1 - commands[i, 0]];
            Array.Copy(array, commands[i, 0] - 1, ints, 0, commands[i, 1] + 1 - commands[i, 0]);
            Array.Sort(ints);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            answer[i] = ints[commands[i, 2] - 1];
        }
        return answer;
    }
}