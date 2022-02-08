using System;

namespace MathLibraryProject {
    class Program {

        public static void Main(string[] args) {

            var a = Math.Add("1", "2"); //string - depending on what parameters you use is what the value of a will call
            var a = Math.Add(1.0m, 2.0m); //decimal
            var a = Math.Add(2, 5); //integer

        }
    }
}
