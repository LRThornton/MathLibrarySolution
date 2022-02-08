using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryProject {

    public static class Math {
        //creates methods
        //polymorphism is when you have more than one method with same name but different parameters
        //all the Adds are called method overloading  the same name can do multiple things

        public static string Add(string a, string b) {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b) {
            return a + b;
        }

        public static long Add(long a, long b){
            return a + b;
        }
            
        public static int Add(int a, int b) {
            return a + b;
        }


        public static int Sub(int a, int b) {
            return a - b;
        }
        public static int Mult(int a, int b) {
            return a * b;
        }
        public static int Div(int a, int b) {
            return a / b;
        }
    }
}
