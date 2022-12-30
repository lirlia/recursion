using System;

public class Solution{
    public static int addEveryOtherElement(int[] intArr){
        // 関数を完成させてください
        int r = 0;
        for (int i = 0; i < intArr.Length; i++) {
          if (i % 2 != 0) r += intArr[i];
        }
        return r;
    }
}
