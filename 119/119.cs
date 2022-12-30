using System;
using System.Collections.Generic;
using System.Linq;

public class Solution{
    public static int[] findJudgePosition(int[] scores){

        // 2チーム以下なら審判がいない
        if (scores.Length <= 2) return new int[]{-1};
        List<int> l = scores.ToList();

        for(int i = 1; i < scores.Length - 1; i++) {
          if (l[0,i].Sum() == l[i + 1,scores.Length].Sum()) return new int[]{i};
        }

        return new int[]{-1};
    }
}
