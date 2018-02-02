// -----------------------------------------------------------------------
//  <copyright file="DateTimeExtensions.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions
{
    using System;
    using System.Linq;

    /// <summary>
    /// All the datetime extensions
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert DateTime to the unix time stamp.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns>The timestamp in unix format</returns>
        public static int ToUnixTimeStamp(this DateTime date)
        {
            return (int)date.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}