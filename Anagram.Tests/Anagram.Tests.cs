using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using System;
using System.Collections.Generic;

namespace Anagram
{
    [TestClass]
    public class CalculateAnagramTest
    {
        [TestMethod]
        public void IsAnagram_CheckIfStringIsAnagram_Bool()
        {
            string tempStringOne = "bread";
            string tempStringTwo = "beard";
            CalculateAnagram myAnagram = new CalculateAnagram();
            Assert.AreEqual(true, myAnagram.IsAnagram(tempStringOne, tempStringTwo));
        }
    }

}