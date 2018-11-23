using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFAOSToolCore.Util
{
    public static class Convert
    {
        public static bool IntToBool(int input)
        {
            return input == 1 ? true : false;
        }
        public static int BoolToInt(bool b)
        {
            return b ? 1 : 0;
        }
    }
}
