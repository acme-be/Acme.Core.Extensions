// -----------------------------------------------------------------------
//  <copyright file="DateTimeExtensionsTests.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The date time extensions tests.
    /// </summary>
    [TestClass]
    public class DateTimeExtensionsTests
    {
        /// <summary>
        /// To the unix time stamp.
        /// </summary>
        [TestMethod]
        public void ToUnixTimeStamp()
        {
            var date = new DateTime(1983, 05, 14, 07, 30, 42);
            var unixTimeStamp = date.ToUnixTimeStamp();
            Assert.AreEqual(421738242, unixTimeStamp);
        }
    }
}