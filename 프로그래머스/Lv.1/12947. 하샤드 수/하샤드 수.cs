public class Solution {
    public bool solution(int x) {
        int sum = 0;
        int start = x;
        while(x >= 10)
        {
            sum += x % 10;
            x /= 10;
        }
        sum += x;
        if (start % sum == 0)
            return true;
        else
            return false;
    }
}