using System;


// time n
// space 1
public class Solution{
    public static string findCommon(char[] charArr1, char[] charArr2){
        // 共通するコマンドがあるか？
        // なければ no common
		string command = "no common";
		int priority = int.MaxValue;

		// コマンドが複数ある場合、合計値はどっちが大きいか？
		for (int i = 0; i < charArr1.Length; i++) {
				int idx = Array.IndexOf(charArr2, charArr1[i]);
				if (idx != -1 && idx + i < priority) {
					priority = idx + i;
					command = charArr1[i].ToString();
				}
		}

        // 同じ場合はプレイヤー1 が先に操作したコマンドを書く

		return command;
    }
}
