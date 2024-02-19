public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int[] cal = new int[]{31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        string[] days = new string[]{"THU","FRI","SAT","SUN","MON","TUE","WED"};
        int sum = 0;
        for (int i = 1; i < a; i++){
            sum += cal[i - 1];
        }
        sum += b;
        answer = days[sum % 7];
        return answer;
    }
}