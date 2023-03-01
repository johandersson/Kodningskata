using NUnit.Framework;
using System;
using System.Linq;

namespace PirateLang
{
    public class PirateLanguageDecrypterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfCharIsConsonant()
        {
            var pirateConverter = new PirateDecrypter();
            char c1 = 'k';
            Assert.IsTrue(pirateConverter.IsConsonant(c1));
        }

        [Test]
        public void TestIfCharIsConsonant2()
        {
            var pirateConverter = new PirateDecrypter();
            char c = 'a';
            Assert.IsFalse(pirateConverter.IsConsonant(c));
        }

       [Test]
        public void TestIfCharIsConsonant3()
        {
            var pirateConverter = new PirateDecrypter();
            char c = 'A';
            Assert.IsFalse(pirateConverter.IsConsonant(c));
        }
        
        [Test]
        public void TestIfCharIsConsonant4()
        {
            var pirateConverter = new PirateDecrypter();
            char c = 'K';
            Assert.IsTrue(pirateConverter.IsConsonant(c));
        }

        [Test]
        public void TestIfCharIsConsonant5()
        {
            var pirateConverter = new PirateDecrypter();
            char c = ' ';
            Assert.IsFalse(pirateConverter.IsConsonant(c));
        }

        [Test]
        public void TestDecryptPirateString()
        {
            var pirateDecrypter = new PirateDecrypter();
            string s1 = "joj";
            Assert.AreEqual("j", pirateDecrypter.DecryptPirateString(s1));
            string s2 = "qoq";
            Assert.AreEqual("q", pirateDecrypter.DecryptPirateString(s2));
            string s3 = "hohejoj alollola rorövovarore";
            Assert.AreEqual("hej alla rövare", pirateDecrypter.DecryptPirateString(s3));
            Assert.AreEqual("", pirateDecrypter.DecryptPirateString(null));
            Assert.AreEqual("", pirateDecrypter.DecryptPirateString(" "));
            string s4 = "HOHEJOJ ALOLLOLA RORÖVOVARORE";
            Assert.AreEqual("HEJ ALLA RÖVARE", pirateDecrypter.DecryptPirateString(s4));
        }




    }
}