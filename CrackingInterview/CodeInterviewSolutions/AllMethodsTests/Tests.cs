using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeInterviewSolutions;
namespace AllMethodsTests
{
    [TestClass]
    public class Tests
    {
        AllMethods actualInstanceToTest = new AllMethods();

        [TestMethod()]
        public void findMinMax_Test()
        {
            CollectionAssert.AreEqual(new int[] { 11,-9 }, actualInstanceToTest.findMaxMin(new int[] { 4, -9, 3, 1, 4, -4, 11, 3 }));
        }

        [TestMethod()]
        public void reversArray_Test()
        {
            CollectionAssert.AreEqual(new int[] { 4,3,2,1 }, actualInstanceToTest.reverseArray(new int[] { 1,2,3,4 }));
        }
    }
}
