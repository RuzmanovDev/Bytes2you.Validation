﻿using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ShortArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsLessThan_Should
    {
        [TestMethod]
        public void AddLessThanValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<short> argument = new ValidatableArgument<short>("argument", 3);

            // Act.
            argument.IsLessThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<short>));
        }
    }
}