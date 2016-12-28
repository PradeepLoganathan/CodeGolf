using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGolf
{
    public class StringsandArrays
    {
        //Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
        // cannot use additional data structures?
        public bool CheckUniqueString(string str)
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

            return IsUnique;
        }

        //Check Permutation:
        //Given two strings, write a method to decide if one is a permutation of the other.
        public bool CheckPermutation(string str1, string str2)
        {
            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            //Array's .Equals method checks for object references and will always return false
            //use LINQ SequenceEquals to check if the Array sequence is the same
            if (c1.SequenceEqual(c2))
                return true;
            else
                return false;
        }


        //URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
        //has sufficient space at the end to hold the additional characters, and that you are given the "true"
        //length of the string.
        public string Urlifyastring(string str, int algotype)
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

            return URLString.ToString();


        }

    }
}

