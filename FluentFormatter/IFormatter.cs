using System;

namespace FluentFormatter
{
    /// <summary>
    ///     Represents a formatter.
    /// </summary>
    public interface IFormatter
    {
        /// <summary>
        ///     The formatted format.
        /// </summary>
        IFormat FormattedFormat { get; }

        /// <summary>
        ///     The unformatted format.
        /// </summary>
        IFormat UnformattedFormat { get; }

        /// <summary>
        ///     Formats an value.
        /// </summary>
        /// <param name="value">The value to ve formatted.</param>
        /// <returns>The formatted value.</returns>
        /// <exception cref="ArgumentException">
        ///     Throw if the value is null or empty.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     Throw if the <paramref name="value" /> can't be used in this formatter.
        /// </exception>
        string Format(string value);

        /// <summary>
        ///     Unformat an value.
        /// </summary>
        /// <param name="value">The value to be unformatted.</param>
        /// <returns>The unformatted value.</returns>
        /// <exception cref="ArgumentException">
        ///     Throw if the value is null or empty.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     Throw if the <paramref name="value" /> can't be used in this formatter.
        /// </exception>
        string Unformat(string value);

        /// <summary>
        ///     Checks if the <paramref name="value" /> is considerate formatted
        ///     by this formatter.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns><c>true</c> if the <paramref name="value" /> is considerate formatted.</returns>
        /// <exception cref="ArgumentException">
        ///     Throw if the value is null or empty.
        /// </exception>
        bool IsFormatted(string value);

        /// <summary>
        ///     Checks if the <paramref name="value" /> is considerate unformatted
        ///     by this formatter.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns><c>true</c> if the <paramref name="value" /> is considerate unformatted.</returns>
        /// <exception cref="ArgumentException">
        ///     Throw if the value is null or empty.
        /// </exception>
        bool IsUnformatted(string value);

        /// <summary>
        ///     Checks if the <paramref name="value" /> can be used
        ///     in this <c>Formatter</c>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns><c>true</c> if the value checks the formats expected.</returns>
        bool IsFormattable(string value);

        /// <summary>
        ///     Asserts if the <paramref name="value" /> can be used
        ///     by this <c>Formatter</c>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <exception cref="InvalidOperationException">
        ///     The value do not respects the formatted or unformatted patterns.
        /// </exception>
        void AssertFormattable(string value);
    }
}