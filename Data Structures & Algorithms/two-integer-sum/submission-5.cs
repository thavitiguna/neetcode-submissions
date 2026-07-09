public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {                        
            int req=target-nums[i];
            if(dict.TryGetValue(req, out int index))
            {
                return new int[] {index,i};
            }
            dict[nums[i]] = i;
          
                
        }
        return new int[2];
    }
}