public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        foreach(int ele in nums)
        {
            if(!hs.Add(ele))
            {
                return true;
            }
        }
        return false;
    }
}