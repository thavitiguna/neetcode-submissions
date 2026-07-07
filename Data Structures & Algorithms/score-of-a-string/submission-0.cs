public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;
        for (int i=1;i<s.Length;i++)
        {
              int temp = (int)s[i-1] - (int)s[i];
              sum = sum + Math.Abs(temp);
        }
        return sum;
        
    }
}