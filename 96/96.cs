using System;
using System.Collections.Generic;
using System.Linq;

// time n
// space 1

public class Solution{
    public static string[] charFrequency(string message){
        // 関数を完成させてください
        Dictionary<string,int> d = new Dictionary<string, int>();

        // dictionary に追加
        foreach(char s in message) {
            if (s == ' ') continue;
            try {
                d[s.ToString()]++;
            } catch {
                d.Add(s.ToString(), 1);
            }
        }

        // list にして返す
		List<string> r = new List<string>();
		foreach (KeyValuePair<string, int> kvp in d) {
		  r.Add($"{kvp.Key} : {kvp.Value}");
		}

		r.Sort();
		return r.ToArray();
    }
}
