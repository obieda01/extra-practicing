using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingInterview;
namespace CrackingInterview.Tests
{
    [TestClass()]
    public class CrackingInterviewTests
    {
        CrackingInterviewMethods actualInstanceToTest = new CrackingInterviewMethods();

        [TestMethod()]
        public void findMinMax_Test()
        {
            CollectionAssert.AreEqual(new int[] { -9, 11 }, actualInstanceToTest.findMaxMin(new int[] { 4, -9, 3, 1, 4, -4, 11, 3 }));
        }
    }
}
