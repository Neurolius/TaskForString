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
    public class LogicTests
    {

        [TestMethod()]
        public void CalculateLetterPercentOnlyLetters()
        {
            var sentence = new Sentence { Text = "Hello" };

            double result = Logic.CalculateLetterPercent(sentence);

            Assert.AreEqual(100, result);
        }

        [TestMethod()]
        public void CalculateLetterPercentWithSymbols()
        {
            var sentence = new Sentence { Text = "Hello!!!" };

            double result = Logic.CalculateLetterPercent(sentence);

            Assert.AreEqual(62.5, result);
        }

        [TestMethod()]
        public void CalculateLetterPercentEmptyString()
        {
            var sentence = new Sentence { Text = "" };

            double result = Logic.CalculateLetterPercent(sentence);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CalculateEachLetterPercentSimpleWord()
        {
            var sentence = new Sentence { Text = "aab" };

            var result = Logic.CalculateEachLetterPercent(sentence);

            Assert.AreEqual(66, result["a"]);
            Assert.AreEqual(33, result["b"]);
        }

        [TestMethod()]
        public void CalculateEachLetterPercentIgnoreCase()
        {
            var sentence = new Sentence { Text = "AaA" };

            var result = Logic.CalculateEachLetterPercent(sentence);

            Assert.AreEqual(100, result["a"]);
        }

        [TestMethod()]
        public void CalculateEachLetterPercentWithSymbols()
        {
            var sentence = new Sentence { Text = "a!a?b" };

            var result = Logic.CalculateEachLetterPercent(sentence);

            Assert.AreEqual(40, result["a"]);
            Assert.AreEqual(20, result["b"]);
        }

        [TestMethod()]
        public void CalculateEachLetterPercentNoLetters()
        {
            var sentence = new Sentence { Text = "12345!!!" };

            var result = Logic.CalculateEachLetterPercent(sentence);

            Assert.AreEqual(0, result.Count);
        }
    }
}