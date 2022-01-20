// -----------------------------------------------------------------------
//  <copyright file="ObjectExtensionsTest.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests;

using System;

using Acme.Core.Extensions.Exceptions;

using Xunit;

/// <summary>
/// The object extensions test.
/// </summary>
public class ObjectExtensionsTest
{
    /// <summary>
    /// Ensure not null with class.
    /// </summary>
    [Fact]
    public void EnsureNotNullWithClass()
    {
        var t = new object();
        var u = t.EnsureNotNull(nameof(t));
        Assert.Equal(t, u);
    }

    /// <summary>
    /// Ensure not null with class and null value.
    /// </summary>
    [Fact]
    public void EnsureNotNullWithNullClass()
    {
        object? t = null;

        // ReSharper disable once ExpressionIsAlwaysNull
        Assert.Throws<ObjectIsNullException>(() => t.EnsureNotNull(nameof(t)));

    }

    /// <summary>
    /// Ensure not null with struct and null value.
    /// </summary>
    [Fact]
    public void EnsureNotNullWithNullStruct()
    {
        int? t = null;

        // ReSharper disable once ExpressionIsAlwaysNull
        Assert.Throws<ObjectIsNullException>(() => t.EnsureNotNull(nameof(t)));
    }

    /// <summary>
    /// Ensure not null with struct.
    /// </summary>
    [Fact]
    public void EnsureNotNullWithStruct()
    {
        int? t = 42;
        var u = t.EnsureNotNull(nameof(t));
        Assert.Equal(t, u);
    }

    /// <summary>
    /// Throw if null with class.
    /// </summary>
    [Fact]
    public void ThrowIfNullWithClass()
    {
        var t = new object();
        t.ThrowIfNull(nameof(t));
    }

    /// <summary>
    /// Throw if null with class and null value.
    /// </summary>
    [Fact]
    public void ThrowIfNullWithNullClass()
    {
        object? t = null;

        // ReSharper disable once ExpressionIsAlwaysNull
        Assert.Throws<ArgumentNullException>(() => t.ThrowIfNull(nameof(t)));
    }

    /// <summary>
    /// Throw if null with struct and null value.
    /// </summary>
    [Fact]
    public void ThrowIfNullWithNullStruct()
    {
        int? t = null;

        // ReSharper disable once ExpressionIsAlwaysNull
        Assert.Throws<ArgumentNullException>(() => t.ThrowIfNull(nameof(t)));
    }

    /// <summary>
    /// Throw if null with struct.
    /// </summary>
    [Fact]
    public void ThrowIfNullWithStruct()
    {
        int? t = 42;
        t.ThrowIfNull(nameof(t));
    }

    /// <summary>
    /// Test the method xecuteOrNull with a simple cas.
    /// </summary>
    [Fact]
    public void ExecuteOrNullSimple()
    {
        var value = "Have a lot of fun !";
        var returned = value.ExecuteOrNull((x) => x.Length);
        Assert.Equal(19, returned);
    }

    /// <summary>
    /// Test the method xecuteOrNull with a null value.
    /// </summary>
    [Fact]
    public void ExecuteOrNullWithNull()
    {
        string? value = null;
        // ReSharper disable once ExpressionIsAlwaysNull
        var returned = value.ExecuteOrNull((x) => x!.Length);
        Assert.Equal(default, returned);
    }
}