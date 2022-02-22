using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COUREAssessment.ModelLayer
{
    public static class Utility
    {
        public static bool IsEven(int Number)
        {
            if (Number % 2 == 0)
                return true;
            else
                return false;
        }
        public static bool Contains8(int Number)
        {
            if (Number == 8)
                return true;
            else
                return false;
        }
    }
}
