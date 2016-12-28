using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeGolf;

namespace CodeGolf.Test
{
    [TestClass]
    public class StringandArraysTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringsandArrays SnA = new StringsandArrays();
            SnA.CheckUniqueString("abcdefghi");
            SnA.Urlifyastring("This is    a  string that   has to    be urilfyied", 1);
            SnA.CheckPermutation("Hello", "oelHl");
        }
    }
}
