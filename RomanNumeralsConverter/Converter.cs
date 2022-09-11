using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsConverter
{
    public class Converter
    {
        public int RomanToInteger(string romanNumeral)
        {
            //Checking if the Roman numeral is empty
            if (!string.IsNullOrEmpty(romanNumeral))
            {
                //Converting the Roman numeral to upper case
                //to handle lower case inputs
                romanNumeral = romanNumeral.ToUpper();
                int number = 0;

                //Dictionary to store Roman numerals and Integer number mapping
                var RomanMap = new Dictionary<string, int>
                {
                    {"I", 1},
                    {"V", 5},
                    {"X", 10}
                };
                 
                //Converting the Roman numeral to integer number
                for (int i = 0; i < romanNumeral.Length; i++)
                {
                    if (i + 1 < romanNumeral.Length && RomanMap[romanNumeral[i].ToString()] < RomanMap[romanNumeral[i + 1].ToString()])
                    {
                        number -= RomanMap[romanNumeral[i].ToString()];
                    }
                    else
                    {
                        number += RomanMap[romanNumeral[i].ToString()];
                    }
                }
                return number;
            }
            else
                throw new ArgumentException("Please enter a value. This can't be empty.");
        }

    }
}
