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
            for (int i = 0; i < sourceArray.Length / 2; i++)
            {
                int chacheValue = sourceArray[i];
                sourceArray[i] = sourceArray[sourceArray.Length - 1 - i];
                sourceArray[sourceArray.Length - 1 - i] = chacheValue;
            }

            return sourceArray;
        }
        public bool allUnique(string sourceString)
        {

            if (sourceString == null || sourceString.Length > 28 || sourceString.Length == 0) return false;
            HashSet<char> charDictionary = new HashSet<char>();
            foreach (char c in sourceString.ToCharArray())
            {
                if (charDictionary.Contains(c)) return false;
                charDictionary.Add(c);
            }
            return true;
        }

        public bool isPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length || str2 == null || str1 == null) return false;
            int[] charCount = new int[255];
            foreach (char c in str1.ToCharArray())
            {
                charCount[c]++;
            }
            foreach (char c in str2.ToCharArray())
            {

                if (--charCount[c] < 0) return false;
            }
            return true;
        }

        public char[] reverseStirng(string sourceSting)
        {

            if (sourceSting == null) return null;
            if (sourceSting.Length == 0) return new char[]{ };
            char[] stringArray = sourceSting.ToCharArray();
            for (int i = 0; i < stringArray.Length / 2; i++)
            {
                char lastChar = stringArray[stringArray.Length - 1 - i];
                stringArray[stringArray.Length-1-i] = stringArray[i];
                stringArray[i] = lastChar;
            }
            
            return stringArray;
        }

        public char[] editString(string sourceString, int length)
        {
            int spaceCount = 0;
            char[] stringChar = sourceString.ToCharArray();
            for (int i = 0; i < length; i++)
            {
                if (stringChar[i] == ' ') spaceCount++; 
            }
            int newLength = length + spaceCount * 2;
            for (int i = length-1; i >0; i--)
            {
                if (stringChar[i] != ' ')
                {
                    stringChar[newLength - 1] = stringChar[i];
                    newLength--;
                }
                else
                {
                    stringChar[newLength - 1] = '0';
                    stringChar[newLength - 2] = '2';
                    stringChar[newLength - 3] = '%';
                    newLength -= 3;
                }
            }

            return stringChar;

        }

        public string compressString(string sourceString)
        {
            StringBuilder sb =  new StringBuilder();
            char[] charString = sourceString.ToCharArray();
            int counter = 1;

            for (int i = 0; i < sourceString.Length-1; i++)
            {
                if (charString[i] == charString[i + 1])
                {
                    counter++;
                }
                else
                {
                    sb.Append(charString[i].ToString());
                    sb.Append(counter.ToString());
                    counter = 1;
                }
            }
            sb.Append(charString[i].ToString());
            sb.Append(counter.ToString());
            return sb.Length >= charString.Length ? sourceString : sb.ToString();
        }
    }
}
