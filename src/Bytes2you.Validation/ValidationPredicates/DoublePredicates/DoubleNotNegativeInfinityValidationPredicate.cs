﻿using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
{
    internal class DoubleNotNegativeInfinityValidationPredicate : SingletonValidationPredicate<DoubleNotNegativeInfinityValidationPredicate, double>
    {
        private DoubleNotNegativeInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return !double.IsNegativeInfinity(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return string.Format(ValidationPredicateMessages.NotNegativeInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(double value)
        {
            return ValidationPredicateMessages.NegativeInfinityMessage;
        }
    }
}