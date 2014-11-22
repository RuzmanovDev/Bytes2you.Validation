﻿using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.OfTypeValidationPredicateTests
{
    [TestClass]
    public class OfTypeValidationPredicate_Constructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenTypeArgumentIsNull()
        {
            // Arrange.
            Type type = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                new OfTypeValidationPredicate<string>(type);
            }, "type");
        }

        [TestMethod]
        public void SetTheGivenTypeToTheTypeProperty_WhenTypeArgumentIsNotNull()
        {
            // Arrange.
            Type type = typeof(object);

            // Act.
            OfTypeValidationPredicate<string> validationPredicate = new OfTypeValidationPredicate<string>(type);

            // Assert.
            Assert.AreEqual(type, validationPredicate.Type);
        }
    }
}