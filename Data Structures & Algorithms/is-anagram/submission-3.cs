public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length!=t.Length)
       {
        return false;
       }
       Dictionary<char,int> dict = new Dictionary<char,int>();
       foreach(char ele in s)
       {
        if(dict.TryGetValue(ele, out int count))
        { 
          dict[ele] = count+1;
        }
        else
        {        
          dict[ele] = 1;
        }
       }
       foreach(char ele in t)
       {
         if(dict.TryGetValue(ele, out int count))
         {
           if(count<=0)
          {
            return false;
          }
           dict[ele] = count-1;
         }
         else
         {
          return false;
         }
       }
       return true;

    }
}
