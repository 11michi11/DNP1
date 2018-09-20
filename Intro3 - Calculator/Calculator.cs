using System;
using System.Collections;

namespace Intro3 {
    namespace MathLib {

        public class Calculator {

            public static int Add (int a, int b) {
                return a + b;
            }

            public static int Add (int[] array) {
                var sum = 0;
                foreach(var num in array)
                    sum += num;
                return sum;
            }

            public static int Max(int a, int b){
                return a > b ? a : b;
            }

            public static int Subtract(int a, int b){
                return a - b;
            }

            public static int Multiply(int a, int b){
                return a * b;
            }

            public static double Divide(int a, int b){
                if(b != 0)
                    return a/b;
                return 0;
                
            }

        }
    }
}