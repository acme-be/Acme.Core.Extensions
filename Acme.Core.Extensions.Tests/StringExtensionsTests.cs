// -----------------------------------------------------------------------
//  <copyright file="StringExtensionsTests.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests;

using Xunit;

/// <summary>
/// The string extensions tests.
/// </summary>
public class StringExtensionsTests
{
    /// <summary>
    /// Replaces the special chars with multiple spaces
    /// </summary>
    [Fact]
    public void ReplaceSpecialCharsWithBeta()
    {
        var result = "This Is Spartaaaaà                !!! ß".ReplaceSpecialChars(true);
        Assert.Equal("this-is-spartaaaaa-b", result);
    }

    /// <summary>
    /// Replaces the special chars with multiple spaces
    /// </summary>
    [Fact]
    public void ReplaceSpecialCharsWithMultipleSpace()
    {
        var result = "This Is Spartaaaaà                !!!".ReplaceSpecialChars(true);
        Assert.Equal("this-is-spartaaaaa", result);
    }

    /// <summary>
    /// Replaces the special chars without replacing the space.
    /// </summary>
    [Fact]
    public void ReplaceSpecialCharsWithoutSpace()
    {
        var result = "This Is Spartaaaaà !!!".ReplaceSpecialChars();
        Assert.Equal("this is spartaaaaa", result);
    }

    /// <summary>
    /// Replaces the special chars with replacing the space.
    /// </summary>
    [Fact]
    public void ReplaceSpecialCharsWithSpace()
    {
        var result = "This Is Spartaaaaà !!!".ReplaceSpecialChars(true);
        Assert.Equal("this-is-spartaaaaa", result);
    }

    /// <summary>
    /// Valide SHA512.
    /// </summary>
    [Fact]
    public void SHA512Null()
    {
        string? nullstring = null;
        // ReSharper disable once ExpressionIsAlwaysNull
        var sha512 = nullstring.SHA512();
        Assert.Null(sha512);
    }

    /// <summary>
    /// Valide SHA512.
    /// </summary>
    [Fact]
    public void SHA512Ok()
    {
        var sha512 = "Hello World".SHA512();
        Assert.Equal("2C74FD17EDAFD80E8447B0D46741EE243B7EB74DD2149A0AB1B9246FB30382F27E853D8585719E0E67CBDA0DAA8F51671064615D645AE27ACB15BFB1447F459B", sha512);
    }
}