// -----------------------------------------------------------------------
//  <copyright file="ObjectExtensions.cs" company="Acme">
//  Copyright (c) Acme. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Acme.Core.Extensions
{
    using System;
    using System.Linq;

    /// <summary>
    /// The object extensions.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Ensures the specified <paramref name="value" /> is not null. Otherwise it throws an
        /// <see cref="ArgumentNullException" />.
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <returns>the specified <paramref name="value" />.</returns>
        public static T EnsureNotNull<T>(this T value, string parameterName)
            where T : class
        {
            value.ThrowIfNull(parameterName);
            return value;
        }

        /// <summary>
        /// Ensures the specified <paramref name="value" /> is not null. Otherwise it throws an
        /// <see cref="ArgumentNullException" />.
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <returns>the specified <paramref name="value" />.</returns>
        public static T? EnsureNotNull<T>(this T? value, string parameterName)
            where T : struct
        {
            value.ThrowIfNull(parameterName);
            return value;
        }

        /// <summary>
        /// Extension method on object, which throws an <see cref="ArgumentNullException" /> if
        /// <paramref name="value" /> is null.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentNullException">Value cannot be null. Parameter name: <paramref name="parameterName" />.</exception>
        public static void ThrowIfNull<T>(this T value, string parameterName)
            where T : class
        {
            if (ReferenceEquals(value, null))
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        /// <summary>
        /// Extension method on object, which throws an <see cref="ArgumentNullException" /> if
        /// <paramref name="value" /> is null.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentNullException">Value cannot be null. Parameter name: <paramref name="parameterName" />.</exception>
        public static void ThrowIfNull<T>(this T? value, string parameterName)
            where T : struct
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        /// <summary>
        /// Execute a call on the source if null, or return the default for the type TReturn.
        /// </summary>
        /// <param name="value">The value to check if null.</param>
        /// <param name="call">The labmda to call if not null.</param>
        /// <typeparam name="TSource">The source type.</typeparam>
        /// <typeparam name="TReturn">The return type of the func.</typeparam>
        /// <returns></returns>
        public static TReturn ExecuteOrNull<TSource, TReturn>(this TSource value, Func<TSource, TReturn> call)
        {
            if (value == null)
            {
                return default;
            }

            return call(value);
        }
    }
}