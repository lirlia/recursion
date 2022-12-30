using System;
using System.Collections.Generic;

// ハッシュパターン
public class Solution{
    public static int[] missingIntegers(int[] numbers){
        // 関数を完成させてください

        Dictionary<int, int> h = new Dictionary<int,int>();

        for (int i = 0; i <= numbers.Length; i++) {
            try {
                h.Add(numbers[i], 1);
    		}catch(Exception){}
        }

		List<int> r = new List<int>(){};

		for (int i = 1; i <= numbers.Length; i++) {
            if (!h.ContainsKey(i)) r.Add(i);
        }

		return r.ToArray();
    }
}



// public class Solution{
//     public static int[] missingIntegers(int[] numbers){
//         // 関数を完成させてください

//         List<int> l = new List<int>(){};
// 		l.Add(1);
//         for (int i = 1; i <= numbers.Length; i++) {
//             l.Add(0);
//         }

// 		for (int i = 0; i < numbers.Length; i++) {
// 			if (numbers[i] <= numbers.Length) l[numbers[i]] = 1;
//         }

// 		List<int> r = new List<int>(){};
// 		for (int i = 0; i < l.Count; i++) {
// 			if (l[i] == 0) r.Add(i);
//         }

// 		return r.ToArray();
//     }
// }
