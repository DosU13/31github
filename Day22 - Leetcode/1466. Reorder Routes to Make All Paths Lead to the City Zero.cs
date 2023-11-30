public class Solution
{
    private int res = 0;
    private List<int>[] links;
    public int MinReorder(int n, int[][] connections)
    {
        links = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            links[i] = new List<int>();
        }
        foreach(var x in connections)
        {
            links[x[0]].Add(x[1]);
            links[x[1]].Add(-x[0]);
        }
        Visit(0, 0);
        return res;
    }

    private void Visit(int i, int previous)
    {
        links[i].Remove(previous);
        links[i].Remove(-previous);
        if (links[i].Count == 0) return;
        foreach (var next in links[i])
        {
            if (next < 0)
            {
                Visit(-next, i);
            }
            else
            {
                res++;
                Visit(next, i);
            }
        }
    }
}