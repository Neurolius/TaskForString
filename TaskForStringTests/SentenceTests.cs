using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskForString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForString.Tests
{
    [TestClass()]
    public class SentenceTests
    {
     
        [TestMethod()]
        public void GetLetterCountOnlyLetters()
        {
            var sentence = new Sentence { Text = "Hello" };

            int result = sentence.GetLetterCount();

            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void GetLetterCountWithSymbols()
        {
            var sentence = new Sentence { Text = "Hello123!!!" };

            int result = sentence.GetLetterCount();

            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void GetLetterCountEmptyString()
        {
            var sentence = new Sentence { Text = "" };

            int result = sentence.GetLetterCount();

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void GetLetterCountNullText()
        {
            var sentence = new Sentence { Text = null };

            int result = sentence.GetLetterCount();

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void GetTotalLengthText()
        {
            var sentence = new Sentence { Text = "Hello!" };

            int result = sentence.GetLength();

            Assert.AreEqual(6, result);
        }

        [TestMethod()]
        public void GetTotalLengthEmptyString()
        {
            var sentence = new Sentence { Text = "" };

            int result = sentence.GetLength();

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void GetTotalLengthNullText()
        {
            var sentence = new Sentence { Text = null };

            int result = sentence.GetLength();

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void GetLowerTextUpperCase()
        {
            var sentence = new Sentence { Text = "HELLO" };

            string result = sentence.GetLowerText();

            Assert.AreEqual("hello", result);
        }

        [TestMethod()]
        public void GetLowerTextMixedCase()
        {
            var sentence = new Sentence { Text = "HeLLo" };

            string result = sentence.GetLowerText();

            Assert.AreEqual("hello", result);
        }

        [TestMethod()]
        public void GetLowerTextNullText()
        {
            var sentence = new Sentence { Text = null };

            string result = sentence.GetLowerText();

            Assert.AreEqual("", result);
        }
    }
}