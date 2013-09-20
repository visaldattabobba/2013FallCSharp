using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppSample1;

namespace UnitTestConsoleAppSample1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 1 + 1;
            Assert.AreEqual(2, num);

            // Not able to test Main() yet
            //ConsoleAppSample1.Program.Main(null);

            var json = ConsoleAppSample1.Program.GetProfile("jewpaltz");
            Assert.IsTrue(json.Contains("Moshe"));
        }

        [TestMethod]
        public void TestThatDogBarks()
        {
            var d = new Dog();

            var actual = d.Bark();
            Assert.AreEqual("woof", actual);
        }

        [TestMethod]
        public void TestThatDogCanSayOtherThings()
        {
            var d = new Dog();
            d.DogsWord = "meyow";

            d.LearnNewWord("Hellow");
            d.LearnNewWord("How Are You");
            var actual = d.Bark();
            Assert.AreEqual("meyow", actual);
        }

      

        [TestMethod]
        public void TestThatDogCanRunAtAnySpeed()
        {
            var d = new Dog();
            d.Speed = 200;

            var actual = d.Run();
            Assert.AreEqual("I am running at 200 Miles an Hour.", actual);
        }



        [TestMethod]
        public void TestDelegate1()
        {
            // Like java code
            //Multiply MyFunc = delegate(int x, int y)
            //{
            //    return x * y;
            //};

            Multiply MyFunc = (x, y) => x * y;
            Assert.AreEqual(4, MyFunc(2, 2));

            // Like java code
            //MyFunc = delegate(int x, int y)
            //{
            //    return x - y;
            //};

            MyFunc = (x, y) => x - y;

            Assert.AreEqual(0, MyFunc(2, 2));
        }

        [TestMethod]
        public void TestDelegate2()
        {
            Func<int, int> Squared = x => x * x;

            Assert.AreEqual(4, Squared(2));
            Assert.AreEqual(9, Squared(3));
        }
    }
}