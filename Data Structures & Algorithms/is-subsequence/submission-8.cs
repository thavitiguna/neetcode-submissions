public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length==0)
        {
            return true;
        }
        if(s.Length>t.Length)
        {
            return false;
        }
        int index =0;
        for(int i=0;i< t.Length && index<s.Length ;i++)
        {
            if(  t[i] == s[index])
            {
              index++;
            }

        }
        return index==s.Length;
        
    }
}