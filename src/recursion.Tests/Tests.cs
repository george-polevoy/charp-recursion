using System.Collections.Generic;
using NUnit.Framework;

namespace recursion.Tests
{
    public class Tests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void TestFiboBaseline(int n, int expected)
        {
            var actual = Fibo.Recursive(n);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCaseSource("TestCases")]
        public void TailRecursive(int n)
        {
            var expected = Fibo.Recursive(n);
            TestContext.WriteLine(expected);
            var actual = Fibo.TailRecursive(n);
            Assert.AreEqual(expected, actual, "Tail version should be equal to baseline");
        }
        
        [TestCaseSource("TestCases")]
        public void Iterative(int n)
        {
            var expected = Fibo.Recursive(n);
            var actual = Fibo.Iterative(n);
            Assert.AreEqual(expected, actual, "Iterative version should be equal to baseline");
        }

        public static IEnumerable<TestCaseData> TestCases()
        {
            for (var i = 0; i < 8; i++)
            {
                yield return new TestCaseData(i);
            }
        }
    }
}