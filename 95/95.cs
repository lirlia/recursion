using System;

public class Solution{
    public static string caesarCiper(string message, int n){
        // 関数を完成させてください

        string r = "";

        // string を foreach で回すと char になる
        foreach (char c in message) {

            // 空白以外なら、文字コードを n だけずらす
            if (c != ' ') {
                int cInt = (int)c + n % 26;
                if (cInt > 122) {
                    cInt = cInt - 26;
                }

                // 文字コードを char に戻す
                r = r + ((char)cInt).ToString();
            }
        }
        return r;
    }
}
