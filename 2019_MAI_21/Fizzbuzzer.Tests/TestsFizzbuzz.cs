using NUnit.Framework;
using Fizzbuzzer;

namespace Tests
{
    public class TestsFizzbuzz
    {
        private Robot robot;
        [SetUp]
        public void Setup()
        {
            robot = new Robot();
        }

        [Test]
        public void OutrosNumeros()
        {
            Assert.AreEqual("1", robot.Fizzbuzz(1));
            Assert.AreEqual("2", robot.Fizzbuzz(2));
            Assert.AreEqual("4", robot.Fizzbuzz(4));
        }

        [Test]
        public void MultiplosDe3()
        {
            Assert.AreEqual("Fizz", robot.Fizzbuzz(3));
            //Assert.AreEqual("Fizz", robot.Fizzbuzz(9));
            //Assert.AreEqual("Fizz", robot.Fizzbuzz(21));
        }

        // [Test]
        // public void MultiplosDe5()
        // {
        //     Assert.AreEqual("Buzz", robot.FizzbuzzM5(5));
        //     Assert.AreEqual("Buzz", robot.FizzbuzzM5(10));
        //     Assert.AreEqual("Buzz", robot.FizzbuzzM5(25));
            
        // }

        // [Test]
        // public void MultiplosDe3e5() 
        // {
        //     Assert.AreEqual("FizzBuzz",robot.FizzbuzzM3e5(15));
        // }
    }
}