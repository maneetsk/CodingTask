using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coding_Task;
using System.Collections.Generic;

namespace Coding_Task.Tests
{
    [TestClass]
    public class UnitTest1
    {
        List<int> allnumbers;
        List<int> allevennumbers;
        List<int> alloddnumbers;
        List<string> allconditionalnumbers;
        List<int> allfibonaccinumbers;

        [TestMethod]
        public void TestSequencesSmall()
        {
            allnumbers = new List<int>();
            allevennumbers = new List<int>();
            alloddnumbers = new List<int>();
            allconditionalnumbers = new List<string>();
            Helpers.NumberFunctions.generateAllNumbersInLoop(50, ref allnumbers, ref allevennumbers, ref alloddnumbers, ref allconditionalnumbers);
        }

        [TestMethod]
        public void TestFibonacciSeriesSmall()
        {
            allfibonaccinumbers = new List<int>();
            Helpers.NumberFunctions.generateFibonacci(50, ref allfibonaccinumbers);
        }

        [TestMethod]
        public void TestSequencesMedium()
        {
            allnumbers = new List<int>();
            allevennumbers = new List<int>();
            alloddnumbers = new List<int>();
            allconditionalnumbers = new List<string>();
            Helpers.NumberFunctions.generateAllNumbersInLoop(1000, ref allnumbers, ref allevennumbers, ref alloddnumbers, ref allconditionalnumbers);
        }

        [TestMethod]
        public void TestFibonacciSeriesMedium()
        {
            allfibonaccinumbers = new List<int>();
            Helpers.NumberFunctions.generateFibonacci(1000, ref allfibonaccinumbers);
        }

        [TestMethod]
        public void TestSequencesLarge()
        {
            allnumbers = new List<int>();
            allevennumbers = new List<int>();
            alloddnumbers = new List<int>();
            allconditionalnumbers = new List<string>();
            Helpers.NumberFunctions.generateAllNumbersInLoop(50000, ref allnumbers, ref allevennumbers, ref alloddnumbers, ref allconditionalnumbers);
        }

        [TestMethod]
        public void TestFibonacciSeriesLarge()
        {
            allfibonaccinumbers = new List<int>();
            Helpers.NumberFunctions.generateFibonacci(50000, ref allfibonaccinumbers);
        }
    }
}
