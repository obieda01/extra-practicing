using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingInterview
{
   public partial class CrackingInterviewMethods
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
    }
}
