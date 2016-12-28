using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckUniqueString("abcdefghi");

            Urlifyastring("This is    a  string that   has to    be urilfyied", 1);

            CheckPermutation("Hello", "oelHl");

        }

        //Check if a string has duplicate characters
        static void CheckUniqueString(string str)
        {
            bool IsUnique = true;

            for (int i = 0; i <= str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        IsUnique = false;
                        break;
                    }
                }
            }

            if (IsUnique)
                Console.WriteLine("String is unique");
            else
                Console.WriteLine("String is not unique");
        }

        static void CheckPermutation(string str1, string str2)
        {
            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            //Array's .Equals method checks for object references and will always return false
            //use LINQ SequenceEquals to check if the Array sequence is the same
            if (c1.SequenceEqual(c2))
                Console.WriteLine("{0} is a permutation of {1} ", str1, str2);
            else
                Console.WriteLine("{0} is not a permutation of {1} ", str1, str2);
        }


        //URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
        //has sufficient space at the end to hold the additional characters, and that you are given the "true"
        //length of the string.
        static void Urlifyastring(string str, int algotype)
        {
            if (algotype == 1)// additional space and not inplace
            {
                StringBuilder URLString = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != ' ')
                    {
                        URLString.Append(str[i]);
                    }
                    else
                    {
                        URLString.Append("%20");
                        while (str[i] == ' ')
                        {
                            ++i;
                        }

                        i--;
                    }
                }

                Console.WriteLine("THe URLified string is {0}", URLString);
            }
            else if (algotype == 2) //Inplace 
            {

            }

        }

    }
}

