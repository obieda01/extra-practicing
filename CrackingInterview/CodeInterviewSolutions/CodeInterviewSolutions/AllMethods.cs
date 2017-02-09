using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviewSolutions
{
    public partial class AllMethods
    {
        public int[] findMaxMin(int[] sourceArray)
        {
            int maxVlaue = int.MinValue;
            int minValue = int.MaxValue;
            foreach (var item in sourceArray)
            {
                if (item < minValue) minValue = item;
                if (item > maxVlaue) maxVlaue = item;
            }
            return new int[] { maxVlaue, minValue };
        }
        public int[] reverseArray(int[] sourceArray)
        {
            for (int i = 0; i < sourceArray.Length/2; i++)
            {
                int chacheValue = sourceArray[i];
                sourceArray[i] = sourceArray[sourceArray.Length - 1-i];
                sourceArray[sourceArray.Length - 1-i] = chacheValue;
            }

            return sourceArray;
        }
    }
}
