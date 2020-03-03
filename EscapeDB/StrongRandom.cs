using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Drawing;
using System.Text;

namespace EscapeDB
{
    public static class xRandom
    {
        [ThreadStatic]
        private static Random _random;

        public static int Get(int inclusiveLowerBound, int inclusiveUpperBound)
        {
            if (_random == null)
            {
                var cryptoResult = new byte[4];
                new RNGCryptoServiceProvider().GetBytes(cryptoResult);

                int seed = BitConverter.ToInt32(cryptoResult, 0);

                _random = new Random(seed);
            }

            int exclusiveUpperBound = inclusiveUpperBound + 1;
            return _random.Next(inclusiveLowerBound, exclusiveUpperBound);
        }

        public static Point GetPoint(int x_min,int x_max,int y_min, int y_max)
        {
            int x = Get(x_min, x_max);
            int y = Get(y_min, y_max);

            return new Point(x, y);
        }

    }
}
