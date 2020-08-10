// -----------------------------------------------------------------------
//  <copyright file="SecurityHelper.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Helpers
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;

    /// <summary>
    /// All helpers for security.
    /// </summary>
    public static class SecurityHelper
    {
        /// <summary>
        /// Create a guid that is secure and not predictable.
        /// </summary>
        /// <returns>A secure guid.</returns>
        public static Guid CreateCryptographicallySecureGuid()
        {
            using (var provider = new RNGCryptoServiceProvider())
            {
                var bytes = new byte[16];
                provider.GetBytes(bytes);
                return new Guid(bytes);
            }
        }
    }
}