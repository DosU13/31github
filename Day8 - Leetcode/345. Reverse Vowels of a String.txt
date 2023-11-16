public class Solution {
    public string ReverseVowels(string s) {
        char[] res = s.ToCharArray();
        int l=nextVowel(s, 0), r=previousVowel(s, s.Length-1); 
        while(l!=-1 && r!=-1 && l<r){
            (res[l], res[r]) = (s[r], s[l]);
            l = nextVowel(s, l+1);
            r = previousVowel(s, r-1);
        }
        return new string(res);
    }

    private char[] vowels = new char[]{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
    private int nextVowel(string s, int i){
        while(i<s.Length){
            if(vowels.Contains(s[i])) return i;
            else i++;
        }
        return -1;
    }

    private int previousVowel(string s, int i){
        while(i>=0){
            if(vowels.Contains(s[i])) return i;
            else i--;
        }
        return -1;
    }
}