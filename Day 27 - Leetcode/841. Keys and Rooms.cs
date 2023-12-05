public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        bool[] b = new bool[rooms.Count];
        List<int> iter = new List<int>{0};
        while(iter.Count>0){
            for(int i = iter.Count -1; i>=0; i--){
                foreach(var x in rooms[iter[i]]){
                    if(!b[x]){
                        b[x] = true;
                        iter.Add(x);
                    }
                }
                iter.RemoveAt(i);
            }
        }
        for(int i = 1; i<b.Length; i++) if(!b[i]) return false; 
        return true;
    }
}
