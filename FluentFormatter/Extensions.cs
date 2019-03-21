using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FluentFormatter
{
    /// <summary>
    ///     Useful extensive functions.
    /// </summary>
    [SuppressMessage("ReSharper", "ParameterOnlyUsedForPreconditionCheck.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class Extensions
    {
        /// <summary>
        ///     Checks if the <c>object</c> is an <c>null</c> <c>object</c> and throw an exception.
        /// </summary>
        /// <param name="obj">The <c>object</c> to check.</param>
        /// <param name="paramName">The name of the param checked.</param>
        /// <param name="message">
        ///     The error message for the exception.
        ///     The default message is in constant <see cref="ErrorMessages" />.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     Throw if the <c>object</c> checked is <c>null</c>.
        /// </exception>
        internal static void Guard(this object obj, string paramName, string message = ErrorMessages.NullOrEmptyError)
        {
            if (obj == null)
                throw new ArgumentNullException(paramName, string.Format(message, paramName));
        }

        /// <summary>
        ///     Checks if the <c>string</c> is an <c>null</c> or <B>empty</B> <c>object</c> and throw an exception.
        /// </summary>
        /// <param name="str">The <c>string</c> to check.</param>
        /// <param name="paramName">The name of the param checked.</param>
        /// <param name="message">
        ///     The error message for the exception.
        ///     The default message is in constant <see cref="ErrorMessages" />.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     Throw if the <c>string</c> checked is <c>null</c> or <B>empty</B>.
        /// </exception>
        internal static void Guard(this string str, string paramName, string message = ErrorMessages.NullOrEmptyError)
        {
            if (str == null)
                throw new ArgumentNullException(paramName, string.Format(message, paramName));

            if (string.IsNullOrEmpty(str))
                throw new ArgumentException(string.Format(message, paramName), paramName);
        }

    }
}