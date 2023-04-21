using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    [TestClass]
    public class AlgorithmClassTest
    {
        [TestMethod]
        public void SelectionSort_ShouldReturnSortArray()
        {
            Assert.AreEqual(10, 200);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            //[1] Arrange (정렬), Setup
            int[] arr = { 33, 22, 11 };

            //[2] Act (동작), Execute
            int[] results = DulAlgorithm.Algorithm.SelectionSort(arr);

            //[3] Assert, Verify
            Assert.AreEqual(11, results[0]); //true
            Assert.AreEqual(22, results[0]); //flase
            

        }
    }

}
