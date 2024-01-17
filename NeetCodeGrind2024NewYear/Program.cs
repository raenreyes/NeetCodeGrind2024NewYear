using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using System.Collections;

namespace NeetCodeGrind2024NewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Reverse(123));
        }
        public static int Reverse(int x)
        {
            int result = 0;

            while(x != 0)
            {
                int remainer = x % 10;
                int temp = result * 10 + remainer;

                if ((temp - remainer) / 10 != result) {

                    return 0;
                }

                result = temp;
                x = x / 10;

            }
            return result;
        }
    }


}


