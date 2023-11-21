public class RecentCounter
{
    Queue<int> vals = new Queue<int>();
    public RecentCounter()
    {
    }

    public int Ping(int t)
    {
        vals.Enqueue(t);
        while (vals.Count > 0 && vals.Peek() + 3000 < t)
        {
            vals.Dequeue();
        }
        return vals.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */