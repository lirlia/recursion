using System;

public class Solution{
    public static string toUpperHeadLowerTail(string word, char alphabet){
        // 関数を完成させてください
        lastIdx = word.LastIndexOf(alphabet);
        if (lastIdx == -1) return word.ToUpper();

        return word.Substring(0, lastIdx - 1).ToUpper() + word.Substring(lastIdx).ToLower();
    }
}
