using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Var01_Class();
            double arg1 = 4;
            double arg2 = 0;
            // act
            double result = calc.Div(arg1, arg2);
        }
    }
}
