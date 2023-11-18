public class Solution
{
    public int MaxVowels(string s, int k)
    {
        string vowels = "aeiou";
        int cnt = s.Take(k).Count(vowels.Contains);
        int res = cnt;
        for(int i = k; i < s.Length; i++)
        {
            if (vowels.Contains(s[i])) cnt++;
            if (vowels.Contains(s[i - k])) cnt--;
            res = Math.Max(res, cnt);
        }
        return res;
    }
}