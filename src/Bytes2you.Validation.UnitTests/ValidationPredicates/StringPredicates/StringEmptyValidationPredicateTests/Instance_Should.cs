﻿using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringEmptyValidationPredicateTests
{
    [TestClass]
    public class Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(StringEmptyValidationPredicate.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(StringEmptyValidationPredicate.Instance, StringEmptyValidationPredicate.Instance);
            }
        }
    }
}