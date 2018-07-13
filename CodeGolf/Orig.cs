using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG
{
    class Orig
    {
        public void Prog(string[] args)
        {
            string input = args[0];

            int length = input.Count();

            //float for .5s
            float midPoint = args[0].Count() / 2f;

            string middleChars = "";

            if (length % 2 == 0)
            {
                middleChars = input.Substring(Convert.ToInt32(midPoint) - 1, 2);
            }
            else
            {
                middleChars = input.Substring(Convert.ToInt32(Math.Floor(midPoint)), 1);
            }

            Console.WriteLine(middleChars);
        }
    }
}

//f