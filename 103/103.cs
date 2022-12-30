using System;
using System.Linq;

public class Solution{
    public static int findIndexToDelete(string password){

        if (isPalindrome(password)) return true;

        for (int i = 0; i < password.Length; i++) {
            string s = password.Remove(i, 1);
            if (isPalindrome(s)) return i;
        }

        return false;
    }

    // 回文かどうかチェックする
    private static bool isPalindrome(string s) {
        return s == string.join("", s.Reverse());
    }
}
