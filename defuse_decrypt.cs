public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int[] decrypted = new int[code.Length];
        if (k==0){
            for(int i=0; i<code.Length; i++){
                decrypted[i] = 0;
            }
            return decrypted;
        }
        if(k>0){
            int number = 0;
            for(int j=0; j<code.Length; j++){
                number = 0;
                for(int i=1; i<=k; i++){
                    int position = i+j;
                    while(position >= code.Length){
                        position -= code.Length;
                    }
                    number = number + code[position];
                }
                decrypted[j] = number;
            }
            return decrypted;
        }
        else{
            k = k * (-1);
            int number = 0;
            for(int j=0; j<code.Length; j++){
                number = 0;
                for(int i=1; i<=k; i++){
                    int position = j-i;
                    while(position < 0){
                        position += code.Length;
                    }
                    number = number + code[position];
                }
                decrypted[j] = number;
            }
            return decrypted;
        }
        return decrypted;
    }
}
