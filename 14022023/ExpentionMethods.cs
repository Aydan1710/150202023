using System;
namespace _14022023
{
	internal static class ExpentionMethods
	{
        public static bool IsOdd(int numOdd)
        {
            if (numOdd % 2 != 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool IsEven(this int numEven)
        {
            if (numEven % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public static bool IsContainsDigit(this string name)
        {
            if (name == null)
            {
                return false;
            }
            foreach (var cr in name)
            {
                if (char.IsDigit(cr))
                    return true;
            }
            return false;


        }

        public static string ToCapitalize(this string str1)
        {
            string newstr = Char.ToUpper(str1[0]) + str1.Substring(1).ToLower();
            return newstr;
        }


        public static int[] GetValueIndexdes(this string str2,char cr)
        {
            int[] indexes = new int[0];
             for(int i=0; i<str2.Length; i++)
            {
                Array.Resize(ref indexes, indexes.Length + 1);
                indexes[indexes.Length - 1] = i;
            }
            return indexes;
        }

    }



}

