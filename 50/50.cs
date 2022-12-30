using System;

public class Solution{
    public static int recursiveDigitsAdded(long digits){
        // 関数を完成させてください
        return (int)f(digits);
    }

    private static int f(long digits, long sum) {
        return digits < 10 ? (int)digits : f(digits / 10, sum + digits % 10);
    }
}


// using System;

// public class Solution{
//     public static int recursiveDigitsAdded(long digits){
//         // 関数を完成させてください
//         return f(digits);
//     }

//     private static int f(long digits, sum) {
//         sum += digits % 10;
//         return sum < 10 ? sum : f(digits / 10, sum);
//         while (true) {
//             sum += digits % 10;
//             digits = digits / 10;

//             if (digits < 1) {
//                 break;
//             }
//         }

//         if (sum > 9) {
//             return f(sum) + sum;
//         }

//         return sum;
//     }
// }
