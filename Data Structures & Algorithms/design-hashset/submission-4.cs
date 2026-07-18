public class MyHashSet {
    private bool[] data; 

    public MyHashSet() {
        data = new bool[10];        
    }
    
    public void Add(int key) {
        if(key>=data.Length)
        {
            Array.Resize(ref data,key+1);
        }
        data[key] = true;
        
    }
    
    public void Remove(int key) {
         if(key<data.Length)
        {
            data[key] = false;
        }
         
        
    }
    
    public bool Contains(int key) {
         if(key>=data.Length)
        {
            return false;;
        }
        return data[key];
        
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */