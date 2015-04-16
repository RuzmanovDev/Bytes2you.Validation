﻿using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.FloatArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNaN_Should
    {
        [TestMethod]
        public void AddFloatNaNValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

            // Act.
            argument.IsNaN();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(FloatNaNValidationPredicate));
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNaN();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}