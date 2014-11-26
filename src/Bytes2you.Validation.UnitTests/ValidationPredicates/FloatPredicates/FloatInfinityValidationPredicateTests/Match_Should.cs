﻿using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.FloatPredicates.FloatInfinityValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsFloatPositiveInfinity()
        {
            // Arrange.
            float value = float.PositiveInfinity;

            // Act.
            IValidationPredicateResult result = FloatInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsFloatNegativeInfinity()
        {
            // Arrange.
            float value = float.NegativeInfinity;

            // Act.
            IValidationPredicateResult result = FloatInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNotFloatInfinity()
        {
            // Arrange.
            float value = 5;

            // Act.
            IValidationPredicateResult result = FloatInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not infinity.", result.Message);
        }
    }
}