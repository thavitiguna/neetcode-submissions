public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n=nums.Length;
        Array.Resize(ref nums,n*2);
        for(int i=0;i<n;i++)
        {
            nums[i+n] =nums[i];
        }
        return nums;       
        
    }
}