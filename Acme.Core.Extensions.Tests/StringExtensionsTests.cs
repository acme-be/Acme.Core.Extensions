// -----------------------------------------------------------------------
//  <copyright file="StringExtensionsTests.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The string extensions tests.
    /// </summary>
    [TestClass]
    public class StringExtensionsTests
    {
        /// <summary>
        /// Replaces the special chars without replacing the space.
        /// </summary>
        [TestMethod]
        public void ReplaceSpecialCharsWithoutSpace()
        {
            var result = "This Is Spartaaaaà !!!".ReplaceSpecialChars();
            Assert.AreEqual("this is spartaaaaa", result);
        }

        /// <summary>
        /// Replaces the special chars with replacing the space.
        /// </summary>
        [TestMethod]
        public void ReplaceSpecialCharsWithSpace()
        {
            var result = "This Is Spartaaaaà !!!".ReplaceSpecialChars(true);
            Assert.AreEqual("this-is-spartaaaaa", result);
        }

        /// <summary>
        /// Replaces the special chars with multiple spaces
        /// </summary>
        [TestMethod]
        public void ReplaceSpecialCharsWithMultipleSpace()
        {
            var result = "This Is Spartaaaaà                !!!".ReplaceSpecialChars(true);
            Assert.AreEqual("this-is-spartaaaaa", result);
        }

        /// <summary>
        /// Replaces the special chars with multiple spaces
        /// </summary>
        [TestMethod]
        public void ReplaceSpecialCharsWithBeta()
        {
            var result = "This Is Spartaaaaà                !!! ß".ReplaceSpecialChars(true);
            Assert.AreEqual("this-is-spartaaaaa-b", result);
        }
    }
}