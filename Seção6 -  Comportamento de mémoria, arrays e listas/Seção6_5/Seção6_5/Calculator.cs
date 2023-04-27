using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção6_5
{
    internal class Calculator
    {
        public static int SumP(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        public static void TripleR(ref int x)
        {
            x = x * 3;
        }

        public static void TripleO(int origin, out int result)
        {
            result = origin * 3;
        }

    }
}
