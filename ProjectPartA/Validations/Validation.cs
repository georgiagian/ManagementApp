using ProjectPartA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectPartA.Validations
{
    public static class Validation
    {
        public static bool IsProperDate(string date)
        {
            DateTime result;
            DateTime.TryParse(date, out result);
            return result == default(DateTime) ? false : true;
        }

        public static bool IsProperTitleOrSubject(string title)
        {
            return !string.IsNullOrWhiteSpace(title);
        }

        public static bool IsProperStream(string stream)
        {
            return Regex.IsMatch(stream, @"^(cb|CB)-[8-9]$|^(cb|CB)-1([0-5])$");
        }

        public static bool IsProperType(string type)
        {
            return Regex.IsMatch(type, @"^(1|2)$");
        }

        public static bool IsProperFirstName(string firstName)
        {
            return (firstName.Any(x => char.IsDigit(x) || char.IsSymbol(x) || x == '!') || string.IsNullOrWhiteSpace(firstName)) ? false : true;
        }

        public static bool IsProperLastName(string lastName)
        {
            return (lastName.Any(x => char.IsDigit(x) || char.IsSymbol(x) || x == '!') || string.IsNullOrWhiteSpace(lastName)) ? false : true;
        }

        public static bool IsProperNumber(string number)
        {
            int resultNumber;
            bool result = int.TryParse(number, out resultNumber);
            return result;
        }

        public static bool IsProperSpaceSeperatedNumbers(string numbers)
        {
            if (numbers == "" || numbers.Contains("0") || numbers.All(x => char.IsWhiteSpace(x)))
            {
                return false;
            }
            return numbers.All(x => char.IsWhiteSpace(x) || char.IsNumber(x));
        }

        public static bool IsCountZero<T1, T2>(List<T1> courses, List<T2> entities ) where T1 : class where T2 : class
        {
            return !(courses.Count == 0 || entities.Count == 0);
        }
    }
}
