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
        /// Returns the Date property of the object of the date is not null. Otherwise, returns null.
        /// </summary>
        /// <param name="date">The date to check.</param>
        /// <returns>The Date property or null.</returns>
        public static DateTime? DateOrNull(this DateTime? date)
        {
            return date.ExecuteOrNull(x => x?.Date);
        }

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