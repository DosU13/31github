public class Solution {
    public string ReverseWords(string s) {
        return string.Join(' ', s.TrimStart().TrimEnd().Split(' ').Where(x => x!="").Reverse());
    }
}