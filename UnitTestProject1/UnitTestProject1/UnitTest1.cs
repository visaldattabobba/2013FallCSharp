using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentUnitTestCases;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MainClass myval = new MainClass();
        [TestMethod]
        public void TestMethod1()
        {
            
            var a11 = new[] { "madhu", "mathews", "john", "moses" };

            Assert.IsNotNull(myval.AllNames(a11), "the list is having some names");
            //Assert.IsTrue(myval.);
        }

        
    }   
}

       
