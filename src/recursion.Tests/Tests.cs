using System.Collections.Generic;
using NUnit.Framework;

namespace recursion.Tests
{
    public class Tests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        [TestCase(6, 6)]
        public void TestFiboBaseline(int n, int expected)
        {
            var actual = Methods.Recursive(n);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCaseSource("TestCases")]
        public void TailRecursive(int n)
        {
            var expected = Methods.Recursive(n);
            TestContext.WriteLine(expected);
            var actual = Methods.TailRecursive(n);
            Assert.AreEqual(expected, actual, "Tail version should be equal to baseline");
        }
        
        [TestCaseSource("TestCases")]
        public void Iterative(int n)
        {
            var expected = Methods.Recursive(n);
            var actual = Methods.Iterative(n);
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