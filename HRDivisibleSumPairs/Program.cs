using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HRDivisibleSumPairs {
    class Program {
        static void Main(string[] args) {

            int[] ar = { 1, 3, 2, 6, 1, 2 };

            int k = 3;
            int n = 6;
            int count = 0;

            for(int i = 0; i < n; i++) {
                for(int j = i + 1; j < n; j++) {
                    if((ar[i] + ar[j]) % k == 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
