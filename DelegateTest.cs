using System;
using static System.Math;

namespace consoleTest
{
    delegate void delTest(int first, int second);
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> pow = (first, second) => {
                Console.WriteLine(first*second);
            };
            Action<int, int> sqrt = (first, second) => {
                Console.WriteLine(Atan2(first, second));
            };
            delTest Random = null;
            Random += new delTest(pow);
            Random += new delTest(sqrt);
            Random(50, 2);
        }
  }
}
