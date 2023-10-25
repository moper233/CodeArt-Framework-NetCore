﻿using System;
using System.Collections.Generic;
using System.Reflection;

using CodeArt.Runtime;
using CodeArt.Runtime.IL;

namespace CodeArt.DomainDriven
{
    /// <summary>
    /// 
    /// </summary>
    public class IntEmptyableRangeValidator : PropertyValidator<Emptyable<int>>
    {
        /// <summary>
        /// 最小长度
        /// </summary>
        public int Min
        {
            get;
            private set;
        }

        /// <summary>
        ///  最大长度
        /// </summary>
        public int Max
        {
            get;
            private set;
        }

        internal IntEmptyableRangeValidator(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }

        protected override void Validate(DomainObject domainObject, DomainProperty property, Emptyable<int> propertyValue, ValidationResult result)
        {
            if (propertyValue.IsEmpty()) return;
            var value = propertyValue.Value;
            if (value < this.Min)
                result.AddError(property.Name, ErrorCode, string.Format(Strings.ValueLessThan, property.Call, this.Min));
            else if (value > this.Max)
                result.AddError(property.Name, ErrorCode, string.Format(Strings.ValueMoreThan, property.Call, this.Max));
        }

        public const string ErrorCode = "IntRangeError";
        

    }
}
