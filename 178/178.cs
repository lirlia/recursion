using System;
using System.Collections.Generic;

// time logn
// space 1
public class Solution{
    public static int[] intersectionOfArraysRepeats(int[] intList1, int[] intList2){
        // 関数を完成させてください

		List<int> l1 = new List<int>(intList1);
		List<int> l2 = new List<int>(intList2);

		List<int> r = new List<int>();
		for (int i = 0; i < l1.Count; i++) {
			int l = l2.IndexOf(l1[i]);
			if (l != -1) {
				l2.RemoveAt(l);
				r.Add(l1[i]);
			}
		}

		r.Sort();
		return r.ToArray();
    }
}
