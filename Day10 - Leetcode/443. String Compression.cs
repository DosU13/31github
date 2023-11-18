public class Solution {
    public int Compress(char[] chars) {
        int j = 1, cnt=1;
        for(int i=1; i<chars.Length; i++){
            if(chars[i]==chars[i-1]){
                cnt++;
            }else {
                if(cnt>1){
                    foreach(char c in cnt.ToString()){
                        chars[j++] = c;
                    }
                    cnt=1;
                }
                chars[j] = chars[i];
                j++;
            }
        }
        if(cnt>1){
            foreach(char c in cnt.ToString()){
                chars[j++] = c;
            }
        }
        return j;
    }
}