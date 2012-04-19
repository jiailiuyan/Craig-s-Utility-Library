﻿/*
Copyright (c) 2012 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities.Validation.Interfaces;
#endregion

namespace Utilities.Validation.BaseClasses
{
    /// <summary>
    /// Rule base class
    /// </summary>
    /// <typeparam name="ObjectType">Object type that the rule applies to</typeparam>
    /// <typeparam name="DataType">Data type of the object validating</typeparam>
    public abstract class Rule<ObjectType, DataType> : IRule<ObjectType>
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ItemToValidate">Item to validate</param>
        /// <param name="ErrorMessage">Error message</param>
        public Rule(Func<ObjectType, DataType> ItemToValidate, string ErrorMessage)
            : base()
        {
            this.ErrorMessage = ErrorMessage;
            this.ItemToValidate = ItemToValidate;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Error message thrown if Validate is not valid
        /// </summary>
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Item to validate
        /// </summary>
        public virtual Func<ObjectType, DataType> ItemToValidate { get; set; }

        #endregion

        #region Functions

        /// <summary>
        /// Validates an object
        /// </summary>
        /// <param name="Object">Object to validate</param>
        public abstract void Validate(ObjectType Object);

        #endregion
    }
}