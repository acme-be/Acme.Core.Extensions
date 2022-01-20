// -----------------------------------------------------------------------
//  <copyright file="ByteArrayExtensionsTests.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests;

using Xunit;

/// <summary>
/// The byte array extensions tests.
/// </summary>
public class ByteArrayExtensionsTests
{
    /// <summary>
    /// To the hexadecimal string.
    /// </summary>
    [Fact]
    public void ToHexadecimalString()
    {
        var array = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var hexadecimalString = array.ToHexadecimalString();
        Assert.Equal("010203040506070809", hexadecimalString);
    }

    /// <summary>
    /// To the hexadecimal string with empty
    /// </summary>
    [Fact]
    public void ToHexadecimalStringEmpty()
    {
        var array = new byte[0];
        var hexadecimalString = array.ToHexadecimalString();
        Assert.Equal(string.Empty, hexadecimalString);
    }
}