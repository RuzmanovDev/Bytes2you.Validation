﻿using System;
using System.Linq;

namespace Bytes2you.Validation.Helpers
{
    public class PortableLazy<T>
    {
        private readonly object lockObject;
        private readonly Func<T> valueFactory;
        private bool isValueCreated;
        private T value;

        public PortableLazy(Func<T> valueFactory)
        {
            if (valueFactory == null)
            {
                throw new ArgumentNullException("valueFactory");
            }

            this.valueFactory = valueFactory;
            this.lockObject = new object();
        }

        public T Value
        {
            get
            {
                if (!this.isValueCreated)
                {
                    lock (this.lockObject)
                    {
                        if (!isValueCreated)
                        {
                            this.value = this.valueFactory();
                            this.isValueCreated = true;
                        }
                    }
                }

                return this.value;
            }
        }
    }
}