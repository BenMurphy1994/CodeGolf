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
            string i = args[0];

            int length = i.Count();

            //float for .5s
            float midPoint = args[0].Count() / 2f;

            int mp = Convert.ToInt32(midPoint);

            string middleChars = "";

            if (length % 2 == 0)
            {
                middleChars = i.Substring(Convert.ToInt32(midPoint) - 1, 2);
            }
            else
            {
                middleChars = i.Substring(Convert.ToInt32(Math.Floor(midPoint)), 1);
            }

            //char[] middleChars1 = length % 2 == 0 ? input[Convert.ToInt32(midPoint)] - 1 : input[Convert.ToInt32(midPoint)];

            char middleChars1 = i[mp];
            //char[] middleChars2 = { 'a', 'b' };
            char[] middleChars2 = length % 2 == 0 ? new char[] { i[mp-1], i[mp] } : new char[] { i[mp] };
            
            Console.WriteLine(length % 2 == 0 ? new char[] { i[mp - 1], i[mp] } : new char[] { i[mp] });

            Console.WriteLine(middleChars);
        }
    }
}