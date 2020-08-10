// -----------------------------------------------------------------------
//  <copyright file="ObjectIsNullException.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Exceptions
{
    using System;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception thrown when an object is null and cannot be.
    /// </summary>
    [Serializable]
    public class ObjectIsNullException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectIsNullException" /> class.
        /// </summary>
        public ObjectIsNullException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectIsNullException" /> class.
        /// </summary>
        /// <param name="message">The message for the exception.</param>
        public ObjectIsNullException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectIsNullException" /> class.
        /// </summary>
        /// <param name="message">The message for the exception.</param>
        /// <param name="inner">The inner exception, if specified.</param>
        public ObjectIsNullException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectIsNullException" /> class.
        /// </summary>
        /// <param name="info">The serialization info.</param>
        /// <param name="context">The Serialization context.</param>
        protected ObjectIsNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}