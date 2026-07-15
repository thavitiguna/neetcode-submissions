public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int req=0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]!=val)
            {
               
                nums[i-req]=nums[i];
               
            }        
            else
            {
                req++;
            } 
            
        }
      
        return nums.Length-req;
        
    }
}