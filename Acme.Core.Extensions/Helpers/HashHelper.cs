// -----------------------------------------------------------------------
//  <copyright file="HashHelper.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Helpers
{
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Static class with some hashes.
    /// </summary>
    public class HashHelper
    {
        /// <summary>
        /// Hashes a string into a SHA512.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The SHA512 from that string in hexa.</returns>
        public static string SHA512(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte
                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                {
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                }

                return hashedInputStringBuilder.ToString();
            }
        }
    }
}