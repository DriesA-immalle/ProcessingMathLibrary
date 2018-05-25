using System;

namespace ProcessingMathLib
{
    public static class ProcessingMathLib
    {
        public static int Sq(int x)
        {
            return x * x; 
        }

        public static int Constrain(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            else if (value > max)
            {
                return max;
            }
            else
            {
                return value;
            }
        }

        public static float Map(float value, float OriginalMin, float OriginalMax, float NewMin, float NewMax)
        {
            return value + (OriginalMax - OriginalMin) * ((value - NewMin) / (NewMax - NewMin));
        }
    }
}
