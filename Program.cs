using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = int.Parse(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            bool isDivisbleByAll = false;
            bool isFound = false;
            while (isFound == false) {
                for (int i = 1; i <= n; i++) {
                    if (num % i == 0) {
                        isDivisbleByAll = true;
                    }
                    else {
                        isDivisbleByAll = false;
                        break;
                    }
                }
                if (isDivisbleByAll) {
                    isFound = true;
					Console.WriteLine(num);
                }
                num++;
            }
        }
    }
}
