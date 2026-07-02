public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n*2];
        
        for( int i=0; i<n*2;i++)
        {
            if(i>=n)
            {
                res[i] =nums[i-n];
            }
            else
            {
             res[i] =nums[i];
            }
        } 
        return res;
        
    }
}