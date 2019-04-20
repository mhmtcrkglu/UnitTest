using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class StringHelper
    {
        // 1.case - Clear begin and end space
        // 2.case - Clear repetitive space (more than one)
        public static string ClearSpaces(string input)
        {
            input = input.Trim();

            string newValue = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' && input[i + 1] == ' ')
                    continue;
                newValue += input[i];
            }

            return newValue;
        }
    }
}
