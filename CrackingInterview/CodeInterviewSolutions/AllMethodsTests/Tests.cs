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
        [TestMethod()]
        public void isUnique_Test()
        {
            Assert.AreEqual(true, actualInstanceToTest.allUnique("Ahmad"));
            Assert.AreEqual(false, actualInstanceToTest.allUnique(""));
            Assert.AreEqual(false, actualInstanceToTest.allUnique("aa"));
            Assert.AreEqual(true, actualInstanceToTest.allUnique("alA"));

        }

        [TestMethod()]
        public void isPerm_Test()
        {
            Assert.AreEqual(true, actualInstanceToTest.isPermutation("Ahmad","hmadA"));
            Assert.AreEqual(false, actualInstanceToTest.isPermutation("","p"));
            Assert.AreEqual(false, actualInstanceToTest.isPermutation("P","p"));
            Assert.AreEqual(true, actualInstanceToTest.isPermutation("cat", "atc"));
        }
        [TestMethod()]
        public void editStringTest()
        {
          // Assert.AreEqual(new char[] {'a','%','2','0','h','%', '2', '0','m' }, actualInstanceToTest.editString("a h m    ",5));
        }

        [TestMethod]
        public void compressString_Tests()
        {
            Assert.AreEqual("ahmad", actualInstanceToTest.compressString("ahmad"));
            Assert.AreEqual("a4",actualInstanceToTest.compressString("aaaa"));
        }
    }
}
