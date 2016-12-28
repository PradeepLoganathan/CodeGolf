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
            StringsandArrays SnA = new StringsandArrays();

            SnA.CheckUniqueString("abcdefghi");
            SnA.Urlifyastring("This is    a  string that   has to    be urilfyied", 1);
            SnA.CheckPermutation("Hello", "oelHl");

        }

    }
}

