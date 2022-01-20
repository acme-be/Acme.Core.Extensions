// -----------------------------------------------------------------------
//  <copyright file="SecurityHelperTests.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests.Helpers
{
    using Acme.Core.Extensions.Helpers;

    using Xunit;

    public class SecurityHelperTests
    {
        [Fact]
        public void CreateCryptographicallySecureGuidOk()
        {
            var guid1 = SecurityHelper.CreateCryptographicallySecureGuid();
            var guid2 = SecurityHelper.CreateCryptographicallySecureGuid();

            Assert.NotEqual(guid1, guid2);
        }
    }
}