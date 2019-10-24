// -----------------------------------------------------------------------
//  <copyright file="ByteArrayExtensions.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// All extensions for the byte array
    /// </summary>
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// To the string hexadecimal.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>The hexadecimal string</returns>
        public static string ToHexadecimalString(this byte[] bytes)
        {
            var output = new StringBuilder();

            foreach (var b in bytes)
            {
                output.Append(b.ToString("x2", CultureInfo.InvariantCulture));
            }

            return output.ToString();
        }
    }
}