using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consuming
{
    internal static class extension
    {
      
            public static string AllEven(this NumericFunction numericfunction, int start, int end)
            {
                StringBuilder sb = new StringBuilder();
               for (int i=start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(i + "\n");
                }
                
            }
            return sb.ToString();
        }


        public static string AllOdd(this NumericFunction numericfunction, int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                if (i % 2 != 0)
                {
                    sb.Append(i + "\n");
                }

            }
            return sb.ToString();
        }


        public static string AllPrime(this NumericFunction numericfunction,int start,int end)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=start; i < end; i++)
            {
                int count = 1;
                for(int j= 2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        count = 0;
                    }
                  
                }
                if (count == 1)
                    sb.Append(i + "\n");

            }
            return sb.ToString();

        }
        public static string PrintTable(this NumericFunction numericfunction , int num)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Table:" + "\n");
            for (int i = 1; i <= 10; i++)
            {
                sb.Append(num + " * " + i + " = " + num * i + "\n");
            }
            return sb.ToString();
        }
        public static string AllTables(this NumericFunction numericfunction, int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                sb.Append("Table of " + i + " :-" + "\n");

                for (int j = 1; j <= 10; j++)
                {
                    sb.Append(i + " * " + j + " = " + i * j + "\n");
                }
            }
            return sb.ToString();
        }

        public static string reverse(this NumericFunction numericfunction, int num)
        {
            string s = num.ToString();
            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static bool isPalindrome(this NumericFunction numericfunction, int num)
        {

            bool isPal = false;
            string s = num.ToString();
            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);
            string str= new string(charArray);

            if (str.CompareTo(s) == 0) { }
            {
                isPal=true;
            }
            return isPal;

            
        }
        public static int countchar(this NumericFunction numericfunction, string str) {
            int count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] != ' ')
                {
                    count++;
                }
            }
            return count;
        }

        public static string reversesenbylet(this NumericFunction numericfunction, string str)
        {
            string s = str.ToString();
            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);
            string string1 =new string(charArray);

            for(int i = 0; i < string1.Length; i++)
            {

            }
        }

    }
}
