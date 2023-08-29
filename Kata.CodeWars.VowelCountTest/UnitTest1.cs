namespace Kata.CodeWars.VowelCountTest
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, Kata.CodeWars.VowelCount.Kata.GetVowelCount("abracadabra"));
        }
    }


}