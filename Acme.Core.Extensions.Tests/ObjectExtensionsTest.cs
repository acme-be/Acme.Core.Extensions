// -----------------------------------------------------------------------
//  <copyright file="ObjectExtensionsTest.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The object extensions test.
    /// </summary>
    [TestClass]
    public class ObjectExtensionsTest
    {
        /// <summary>
        /// Ensure not null with class.
        /// </summary>
        [TestMethod]
        public void EnsureNotNullWithClass()
        {
            var t = new object();
            var u = t.EnsureNotNull(nameof(t));
            Assert.AreEqual(t, u);
        }

        /// <summary>
        /// Ensure not null with class and null value.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EnsureNotNullWithNullClass()
        {
            object t = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            t.EnsureNotNull(nameof(t));
        }

        /// <summary>
        /// Ensure not null with struct and null value.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EnsureNotNullWithNullStruct()
        {
            int? t = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            t.EnsureNotNull(nameof(t));
        }

        /// <summary>
        /// Ensure not null with struct.
        /// </summary>
        [TestMethod]
        public void EnsureNotNullWithStruct()
        {
            int? t = 42;
            var u = t.EnsureNotNull(nameof(t));
            Assert.AreEqual(t, u);
        }

        /// <summary>
        /// Throw if null with class.
        /// </summary>
        [TestMethod]
        public void ThrowIfNullWithClass()
        {
            var t = new object();
            t.ThrowIfNull(nameof(t));
        }

        /// <summary>
        /// Throw if null with class and null value.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowIfNullWithNullClass()
        {
            object t = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            t.ThrowIfNull(nameof(t));
        }

        /// <summary>
        /// Throw if null with struct and null value.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowIfNullWithNullStruct()
        {
            int? t = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            t.ThrowIfNull(nameof(t));
        }

        /// <summary>
        /// Throw if null with struct.
        /// </summary>
        [TestMethod]
        public void ThrowIfNullWithStruct()
        {
            int? t = 42;
            t.ThrowIfNull(nameof(t));
        }
    }
}