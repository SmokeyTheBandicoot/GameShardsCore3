using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GameShardsCore3.Mathematics.Operators {
    public static class Operators {

        public static BigInteger Factorial(uint num) {
            BigInteger result = 0;
            for (long x = 2; x < num - 1; x++) {
                result *= x;
            }
            return result;
        }

    }
}
