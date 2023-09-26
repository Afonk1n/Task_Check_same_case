using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_same_case
{
    internal class Program
    {
        static int characterComparison(char a, char b)
        {
            if (char.ToLower(a) == char.ToUpper(a) || char.ToLower(b) == char.ToUpper(b))
            {
                return -1;
            }else if (a == char.ToLower(a) && b == char.ToLower(b) || a == char.ToUpper(a) && b == char.ToUpper(b))
            {
                return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine(characterComparison(a, b));
            Console.ReadLine();
        }
    }
}
