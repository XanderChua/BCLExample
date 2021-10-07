using System;
using System.Collections.Generic;
using System.Linq;

namespace BCLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Yes to run the code");
            //var input = Console.ReadLine();
            //Console.WriteLine("String in lower case: " + input.ToLower());
            //Console.WriteLine("String in upper case: " + input.ToUpper());

            ////input - this is a SAMple seSSION.
            //var str1 = "this_is_a_SAMple_seSSION";

            //Console.WriteLine("The string in correct format");
            ////output - This is a sample session
            //Console.WriteLine(char.ToUpper(str1[0]) + str1.Substring(1).ToLower());

            //var lst = str1.Split('_');
            //foreach(string str in lst)
            //{
            //    Console.WriteLine(str);
            //}

            //string str3 = null;
            //if (string.IsNullOrEmpty(str3))
            //{
            //    Console.WriteLine("str3 is null or empty");
            //}
            //var str2 = " ";
            //if (string.IsNullOrEmpty(str2))
            //{
            //    Console.WriteLine("Is null or empty");
            //}
            //if (string.IsNullOrWhiteSpace(str2))
            //{
            //    Console.WriteLine("Is null or whitespace");
            //}

            DateTimeDifference();

            Console.ReadLine();
            //ReverseString();
            //StringBCLExamples();
            //DateTimeMethod();
            //ConcatTrim();
        }

        private static void DateTimeDifference()
        {
            Console.WriteLine("Enter a datetime:");
            var now = DateTime.Now;
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime datetimeobj))
            {
                Console.WriteLine("Valid");
                if (now > datetimeobj)
                {
                    Console.WriteLine("Difference: " + (now - datetimeobj));
                }
                else
                {
                    Console.WriteLine("Difference: " + (datetimeobj - now));
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        private static void ConcatTrim()
        {
            string str4 = "This is ";
            string str5 = "sample program";
            Console.WriteLine(string.Concat(str4, str5));

            string str6 = "//****    This is a sample string    ****//";
            char[] chartoremove = { ' ' };
            char[] chartoremove1 = { '*', '/', ' ' };
            var trimmedString = str6.Trim(chartoremove);
            Console.WriteLine("Removed all whitespace: " + trimmedString);
            var trimmedString2 = str6.Trim(chartoremove1);
            Console.WriteLine("Removed all char: " + trimmedString2);
        }

        private static void DateTimeMethod()
        {
            DateTime dateTime = System.DateTime.Now;

            Console.WriteLine(dateTime.Date);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToShortTimeString());

            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());

            Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
            Console.WriteLine(dateTime.ToString("dd-MMM-yyyy"));
            Console.WriteLine(dateTime.ToString("dd-MMMM-yyyy"));

            string str = "07/10/2021 23:05";
            DateTime.TryParse(str,out DateTime datetimeobj);
            Console.WriteLine(datetimeobj);

            //DateTime datetimeobject1 = new DateTime(2021,10,07,12,00,00);
            //DateTime datetimeobject2 = new DateTime(2021, 10, 07, 12, 00, 00);
            var datetimeobject1 = DateTime.Now.ToShortDateString();
            var datetimeobject2 = DateTime.Now.AddDays(10);
            var daysInMonth = DateTime.DaysInMonth(2021, 10);            
            Console.WriteLine(daysInMonth);
            var leapYear = DateTime.IsLeapYear(2024);
            Console.WriteLine(leapYear);

            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine(DateTime.MinValue);

            if (datetimeobject1.Equals(datetimeobject2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

        }

        private static void ReverseString()
        {
            string input = "I love to code in C#";

            string[] arrStr = input.Split(' ');
            foreach (string str in arrStr.Reverse())
            {
                Console.Write($"{str.Substring(0, 1).ToUpper()}{str.Substring(1)} ");
            }
        }

        private static void StringBCLExamples()
        {
            List<string> lst = new List<string>();

            string str1 = "SampleDemo";//S 083
            string str2 = "sampleDemo";//s 115

            lst.Add(str1);
            lst.Add(str2);

            Console.WriteLine("Before sorting");
            foreach(string temp in lst)
            {
                Console.WriteLine(temp);
            }
            var arr = lst.ToArray();
            Array.Sort(arr);

            Console.WriteLine("\nAfter sorting");
            foreach(string temp in arr)
            {
                Console.WriteLine(temp);
            }

            int res = String.Compare(str1, str2, ignoreCase: false);
            Console.WriteLine("Result of string compare SampleDemo & sampleDemo is: " + res);

            string str3 = "S";
            string str4 = "s";
            int res1 = String.Compare(str3, str4, true);
            Console.WriteLine("Result of string compare is: " + res1);

            string str5 = "s";
            string str6 = "S";
            int res2 = str5.CompareTo(str6);
            Console.WriteLine("Result of string compare is: " + res2);
        }
    }
}
