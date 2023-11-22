public class Solution
{
    public int PairSum(ListNode head)
    {
        var list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        int max = 0;
        for(int i=0; i<list.Count/2; i++)
        {
            max = Math.Max(max, list[i] + list[list.Count-1-i]);
        }
        return max;
    }
}