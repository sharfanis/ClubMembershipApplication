using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FieldValidatorAPI
{
    public delegate bool RequiredValidDel(string fieldVal);

    public delegate bool StringlengthValidDel(string fieldVal, int minLen, int maxLen);

    public delegate bool DateValidDel(string fieldVal, out DateTime validDate);

    public delegate bool PatternMatchDel(string fieldVal, string pattern);

    public delegate bool CompareFieldValidDel(string fieldVal, string fieldValCompare);

    public class CommonFieldValidatorFunction
    {
        private static RequiredValidDel _requiredValidDel = null;
        private static StringlengthValidDel _stringlengthValid = null;
        private static DateValidDel _dateValidDel = null;
        private static PatternMatchDel _patternMatchDel = null;
        private static CompareFieldValidDel _compareFieldValidDel = null;



        // The function implementation
        private static bool RequiredFieldValid(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal))
                return true;

            return false;
        }

        private static bool StringlengthValid(string fieldVal, int minLen, int maxLen)
        {
            if (fieldVal.Length >= minLen && fieldVal.Length <= maxLen)
                return true;

            return false;
        }

        private static bool DateFieldValid(string fieldVal, out DateTime validDate)
        {
            if (DateTime.TryParse(fieldVal, out validDate))
                return true;

            return false;
        }

        private static bool PatternMatchValid(string fieldVal, string regualrExprssionPatern)
        {
            Regex regex = new Regex(regualrExprssionPatern);

            if (regex.IsMatch(fieldVal))
                return true;

            return false;
        }

        private static bool CompareFieldValid(string fieldVal, string fieldValCompare)
        {
            if (fieldVal.Equals(fieldValCompare))
                return true;

            return false;
        }

    }
}
