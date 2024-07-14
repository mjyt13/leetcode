public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        } 
        else {
            int y = x;
            int q = QuantityDigits(y);
            for(int i=0;i<q/2;i++){
                int digit1 = (y / TenPow(q-i-1)) % 10; 
                int digit2 = (y % TenPow(i+1)) / TenPow(i) ;
                if(digit1 != digit2){
                    return false;
                }
            }
            return true;
        }
    }
    public int QuantityDigits(int y){
        int quan = 0;
        while(y > 0){
            y = y / 10;
            quan++;
        }
        return quan;
    }
    public int TenPow(int exp){
        int res = 1;
        for(int i=0;i<exp;i++){
            res = res * 10;
        }
        return res;
    }
}
