public class Solution
{
    private bool[] visited;
    private List<int>[] connections;
    public int FindCircleNum(int[][] isConnected)
    {
        int res = 0;
        visited = new bool[isConnected.Length];
        connections = new List<int>[isConnected.Length];
        for (int i = 0; i < connections.Length; i++)
            connections[i] = new List<int>();

        for (int i = 0; i < isConnected.Length; i++)
        {
            for (int j = 0; j < isConnected[i].Length; j++)
            {
                if (isConnected[i][j] == 1)
                {
                    connections[i].Add(j);
                    connections[j].Add(i);
                }
            }
        }

        for (int i = 0; i < visited.Length; i++)
        {
            if (visited[i] == false)
            {
                res++;
                Visit(i);
            }
        }
        return res;
    }

    private void Visit(int i)
    {
        Console.WriteLine(i);
        if (visited[i]) return;
        visited[i] = true;
        foreach (int j in connections[i])
        {
            Visit(j);
        }
    }
}