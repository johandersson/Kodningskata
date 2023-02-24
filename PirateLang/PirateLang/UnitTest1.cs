using NUnit.Framework;
using System;
using System.Linq;

namespace PirateLang
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfCharIsConsonant()
        {
            char c1 = 'k';
            Assert.IsTrue(IsConsonant(c1));
        }

        [Test]
        public void TestIfCharIsConsonant2()
        {
             char c = 'a';
            Assert.IsFalse(IsConsonant(c));
        }

        [Test]
        public void TestIfCharIsConsonant3()
        {
            char c = 'A';
            Assert.IsFalse(IsConsonant(c));
        }

        [Test]
        public void TestIfCharIsConsonant4()
        {
            char c = 'K';
            Assert.IsTrue(IsConsonant(c));
        }

        [Test]
        public void TestIfCharIsConsonant5()
        {
            char c = ' ';
            Assert.IsFalse(IsConsonant(c));
        }


        private bool? IsConsonant(char c)
        {
            string consonantsStr = "bcdfghjklmnpqrstvxz";
            if (consonantsStr.Contains(c) || consonantsStr.ToUpper().Contains(c))  
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}