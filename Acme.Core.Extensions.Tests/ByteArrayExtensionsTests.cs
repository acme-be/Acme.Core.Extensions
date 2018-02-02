// -----------------------------------------------------------------------
//  <copyright file="ByteArrayExtensionsTests.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The byte array extensions tests.
    /// </summary>
    [TestClass]
    public class ByteArrayExtensionsTests
    {
        /// <summary>
        /// To the hexadecimal string.
        /// </summary>
        [TestMethod]
        public void ToHexadecimalString()
        {
            var array = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var hexadecimalString = array.ToHexadecimalString();
            Assert.AreEqual("010203040506070809", hexadecimalString);
        }

        /// <summary>
        /// To the hexadecimal string with empty
        /// </summary>
        [TestMethod]
        public void ToHexadecimalStringEmpty()
        {
            var array = new byte[0];
            var hexadecimalString = array.ToHexadecimalString();
            Assert.AreEqual(string.Empty, hexadecimalString);
        }
    }
}