using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeGolf;
using System.Diagnostics;

namespace CodeGolf.Test
{
    [TestClass]
    public class StringandArraysTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestCheckUniqueString()
        {
            StringsandArrays SnA = new StringsandArrays();
            Assert.IsTrue(SnA.CheckUniqueString("abcdefghi"));
            Assert.IsFalse(SnA.CheckUniqueString("Hello"));
        }

        [TestMethod]
        public void UrlifyastringTest()
        {
            StringsandArrays SnA = new StringsandArrays();
            string urlified;
            urlified = SnA.Urlifyastring("This is    a  string that   has to    be urilfyied", 1);
            Assert.IsTrue(urlified.Equals("This%20is%20a%20string%20that%20has%20to%20be%20urilfyied"));
        }

        [TestMethod]
        public void CheckPermutationTest()
        {
            StringsandArrays SnA = new StringsandArrays();
            Assert.IsTrue(SnA.CheckPermutation("Hello", "oelHl"));

        }

        [TestMethod]
        public void CheckPermutationOfPalindromeTest()
        {
            StringsandArrays SnA = new StringsandArrays();
            string[] palindromes;

            Assert.IsTrue(SnA.CheckPermutationOfPalindrome("Tenet", out palindromes));
            Debug.WriteLine(String.Join(", ", palindromes));
            
            
        }



    }
}
