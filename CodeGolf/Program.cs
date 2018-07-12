using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool test = int.TryParse(args[0], out num);
            Console.WriteLine(test);
        }
    }
}
