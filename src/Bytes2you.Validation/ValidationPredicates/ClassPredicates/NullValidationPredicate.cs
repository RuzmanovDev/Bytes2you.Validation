﻿using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.ClassPredicates
{
    internal class NullValidationPredicate<T> : ValidationPredicate<T>
        where T : class
    {
        private static readonly PortableLazy<NullValidationPredicate<T>> lazyInstance;

        static NullValidationPredicate()
        {
            lazyInstance = new PortableLazy<NullValidationPredicate<T>>(() => new NullValidationPredicate<T>());
        }

        private NullValidationPredicate()
        {
        }

        public static NullValidationPredicate<T> Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Default;
            }
        }

        protected override string GetMatchMessage(T value)
        {
            return ValidationPredicateMessages.NullMessage;
        }

        protected override string GetUnmatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullMessage, value);
        }

        protected override bool IsMatch(T value)
        {
            return value == null;
        }
    }
}