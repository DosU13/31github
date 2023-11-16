public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int zerosCnt = 1;
        foreach(int x in flowerbed){
            if(x == 0) zerosCnt++;
            else{
                n -= (zerosCnt - 1)/2;
                zerosCnt = 0;
            }
        }
        zerosCnt++;
        n -= (zerosCnt - 1)/2;
        return n <= 0;
    }
}