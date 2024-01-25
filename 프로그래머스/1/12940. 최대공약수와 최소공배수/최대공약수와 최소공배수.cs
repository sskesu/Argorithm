public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2] ;
        int big, small;
        if (n > m){
            big = n;
            small = m;
        }
        else if (n < m){
            big = m;
            small = n;
        }
        else{
            return new int[]{n, n};
        }
        for (int i = small; i >= 1; i--){
            if (big % i == 0 && small % i == 0){
                answer[0] = i;
                answer[1] = big * small / i;
                break;
            }
        }
        return answer;
    }
}