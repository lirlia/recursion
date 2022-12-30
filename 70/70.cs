using System;

public class Solution{
    public static char[] generateAlphabet(char firstAlphabet, char secondAlphabet){
        // 関数を完成させてください
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        int s = alphabet.IndexOf(firstAlphabet.ToString().ToLower());
        int e = alphabet.IndexOf(secondAlphabet.ToString().ToLower());
        return alphabet.Substring(s, (e - s + 1)).split();
    }
}
