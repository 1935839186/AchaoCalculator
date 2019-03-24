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

            int Shu()//产生1~100的随机数
            {                Random A = new Random();                int x = A.Next(1, 100);                return x;            }
        }
    }
}
