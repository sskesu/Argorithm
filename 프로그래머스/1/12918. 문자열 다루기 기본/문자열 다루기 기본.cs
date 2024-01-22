using System;
public class Solution {
    public bool solution(string s) {
        int num;
        if (s.Length != 4 && s.Length != 6)
            return false;
        for (int i = 0; i < s.Length; i++)
        {
            if (!int.TryParse(s.Substring(i, 1), out num))
                return false;
        }
        return true;
    }
}