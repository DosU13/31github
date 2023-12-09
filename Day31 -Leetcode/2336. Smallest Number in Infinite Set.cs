public class SmallestInfiniteSet
{
    private PriorityQueue<int, int> set = new PriorityQueue<int, int>();
    private int smallest = 1;
    public SmallestInfiniteSet()
    {

    }

    public int PopSmallest()
    {
        if(set.Count == 0 || smallest < set.Peek())
        {
            smallest++;
            return smallest-1;
        }else 
        {
            var deq = set.Dequeue();
            while(set.Count > 0 && set.Peek() == deq) set.Dequeue();
            return deq;
        }
    }

    public void AddBack(int num)
    {
        if(smallest > num)
        {
            set.Enqueue(num, num);
        }
    }
}
