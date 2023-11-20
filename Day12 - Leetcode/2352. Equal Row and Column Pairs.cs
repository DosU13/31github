using System.Text;

public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        foreach (int[] row in grid)
        {
            string key = string.Join(",", row);
            if(dic.ContainsKey(key)) dic[key]++;
            else dic[key] = 1;
        }
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < grid.Length; i++)
        {
            stringBuilder.Clear();
            stringBuilder.Append(grid[0][i]);
            for (int j = 1; j < grid.Length; j++)
            {
                stringBuilder.Append(",");
                stringBuilder.Append(grid[j][i]);
            }

            string key = stringBuilder.ToString();
            if (dic.ContainsKey(key)) dic[key]+=1000;
            else dic[key] = 1000;
        }
        int res = 0;
        foreach (var pair in dic.Values)
        {
            res += (pair % 1000) * (pair / 1000);
        }
        return res;
    }
}