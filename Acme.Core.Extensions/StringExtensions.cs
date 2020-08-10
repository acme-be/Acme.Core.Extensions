// -----------------------------------------------------------------------
//  <copyright file="StringExtensions.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    using Acme.Core.Extensions.Helpers;

    /// <summary>
    /// Contains all the extensions to string.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Replaces the special chars.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="replaceWitheSpaces">if set to <c>true</c>, replace white spaces with '-'.</param>
        /// <returns>
        /// The string without any special chars, alors remove spaces.
        /// </returns>
        public static string ReplaceSpecialChars(this string value, bool replaceWitheSpaces = false)
        {
            value = value.ToLowerInvariant();

            if (replaceWitheSpaces)
            {
                value = value.Replace(" ", "-");
            }

            value = value.Normalize(NormalizationForm.FormKD);
            value = value.Replace("ß", "b");
            var encodedValue = new StringBuilder(value.Length);

            foreach (var c in value)
            {
                if ((c >= 48 && c <= 57) || (c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c == '-' || c == '_' || c == ' ')
                {
                    encodedValue.Append(c);
                }
            }

            value = encodedValue.ToString();
            value = Regex.Replace(value, "[-]+", "-").Trim('-', ' ');

            return value;
        }

        /// <summary>
        /// Returns the SHA512 for a string.
        /// </summary>
        /// <param name="value">The value to be hashed.</param>
        /// <returns>The computed SHA512.</returns>
        public static string SHA512(this string value)
        {
            return value == null ? null : HashHelper.SHA512(value);
        }
    }
}