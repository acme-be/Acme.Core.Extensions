// -----------------------------------------------------------------------
//  <copyright file="DateTimeExtensionsTests.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions.Tests;

using System;

using Xunit;

/// <summary>
/// The date time extensions tests.
/// </summary>
public class DateTimeExtensionsTests
{
    /// <summary>
    /// To the unix time stamp.
    /// </summary>
    [Fact]
    public void ToUnixTimeStamp()
    {
        var date = new DateTime(1983, 05, 14, 07, 30, 42);
        var unixTimeStamp = date.ToUnixTimeStamp();
        Assert.Equal(421738242, unixTimeStamp);
    }

    /// <summary>
    /// Test the DateOrNull method, with a specified value.
    /// </summary>
    [Fact]
    public void DateOrNullOk()
    {
        DateTime? date = new DateTime(1983,5,14,23,56,0);
        var returned = date.DateOrNull();
        Assert.Equal(new DateTime(1983, 5, 14), returned);
    }

    /// <summary>
    /// Test the DateOrNull method, with a null value.
    /// </summary>
    [Fact]
    public void DateOrNullWith()
    {
        DateTime? date = null;
        // ReSharper disable once ExpressionIsAlwaysNull
        var returned = date.DateOrNull();
        Assert.Null(returned);
    }
}