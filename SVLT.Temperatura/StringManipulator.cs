using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVLT.Temperatura
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;

            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;

                left++;
                right--;
            }

            return new string(charArray);
        }

        public string RemoveSpaces(string input)
        {
            string remove = new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
            return remove;
        }
    }
}
