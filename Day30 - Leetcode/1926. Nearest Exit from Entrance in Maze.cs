public class Solution
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        bool[,] stept = new bool[maze.Length, maze[0].Length];

        int res = 0;
        Stack<(int,int)> stack = new Stack<(int, int)>();
        stack.Push((entrance[0], entrance[1]));
        stept[entrance[0], entrance[1]] = true;
        while (true)
        {
            res++;
            Stack<(int, int)> stack2 = new Stack<(int, int)>();  
            foreach(var t in stack)
            {
                if (t.Item1 != 0 && maze[t.Item1 - 1][t.Item2] == '.') 
                {
                    if (stept[t.Item1 - 1, t.Item2] == false) {
                        if(t.Item1 == 1 || t.Item2 == 0 || t.Item2 == maze[0].Length-1) return res;
                        stack2.Push((t.Item1 - 1, t.Item2));
                        stept[t.Item1 - 1, t.Item2] = true;
                    }
                }
                if (t.Item1 != maze.Length - 1 && maze[t.Item1 + 1][t.Item2] == '.')
                {
                    if (stept[t.Item1 + 1, t.Item2] == false)
                    {
                        if(t.Item1 + 2 == maze.Length || t.Item2 == 0 || t.Item2 == maze[0].Length - 1) return res;
                        stack2.Push((t.Item1 + 1, t.Item2));
                        stept[t.Item1 + 1, t.Item2] = true;
                    }
                }
                if (t.Item2 != 0 && maze[t.Item1][t.Item2 - 1] == '.')
                {
                    if (stept[t.Item1, t.Item2 - 1] == false)
                    {
                        if(t.Item2 == 1 || t.Item1 == 0 || t.Item1 == maze.Length - 1) return res;
                        stack2.Push((t.Item1, t.Item2 - 1));
                        stept[t.Item1, t.Item2 - 1] = true;
                    }
                }
                if (t.Item2 != maze[0].Length - 1 && maze[t.Item1][t.Item2 + 1] == '.')
                {
                    if (stept[t.Item1, t.Item2 + 1] == false)
                    {
                        if(t.Item2 + 2 == maze[0].Length || t.Item1 == 0 || t.Item1 == maze.Length - 1) return res;
                        stack2.Push((t.Item1, t.Item2 + 1));
                        stept[t.Item1, t.Item2 + 1] = true;
                    }
                }
            }
            if (stack2.Count == 0) return -1;
            stack = stack2;
        }
    }
}