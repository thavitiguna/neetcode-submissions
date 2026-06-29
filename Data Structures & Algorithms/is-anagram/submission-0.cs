public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length!=t.Length)
       {
        return false;
       }
       Dictionary<char,int> dict = new ();
       foreach(char c in s)
       {
          if(dict.TryGetValue(c,out int count))
          {
            dict[c]=count+1;
          }
          else
          {
            dict[c] = 1;
          }
       }
       foreach(char c in t)
       {
            if(!dict.ContainsKey(c))
            {
                return false;
            }
            dict[c]--;
            if(dict[c]<0)
            {
                return false;
            }
       }
       return true;

    }
}
