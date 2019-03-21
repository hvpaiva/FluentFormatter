using System;
using System.Diagnostics.CodeAnalysis;

namespace FluentFormatter
{
    /// <inheritdoc />
    /// <summary>
    ///     An base class for formatters.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Provides the implementation to the operations
    ///         <see cref="M:FluentFormatter.Formatter.Format(System.String)" />,
    ///         <see cref="M:FluentFormatter.Formatter.Unformat(System.String)" />,
    ///         <see cref="M:FluentFormatter.Formatter.IsFormatted(System.String)" />,
    ///         <see cref="M:FluentFormatter.Formatter.IsUnformatted(System.String)" />,
    ///         <see cref="M:FluentFormatter.Formatter.IsFormattable(System.String)" /> and
    ///         <see cref="M:FluentFormatter.Formatter.AssertFormattable(System.String)" />
    ///         following the formatted <see cref="IFormat"/> and unformatted
    ///         <see cref="IFormat" />.
    ///     </para>
    /// </remarks>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class Formatter : IFormatter
    {
        /// <summary>
        ///     Constructs the base formatter.
        /// </summary>
        /// <param name="formattedFormat">The formatted format.</param>
        /// <param name="unformattedFormat">The unformatted format.</param>
        protected Formatter(IFormat formattedFormat, IFormat unformattedFormat)
        {
            FormattedFormat = formattedFormat;
            UnformattedFormat = unformattedFormat;
        }

        /// <inheritdoc />
        public IFormat FormattedFormat { get; }

        /// <inheritdoc />
        public IFormat UnformattedFormat { get; }

        /// <inheritdoc />
        public string Format(string value)
        {
            value.Guard(nameof(value));
            AssertFormattable(value);

            return IsFormatted(value)
                ? value
                : UnformattedFormat.Pattern.Replace(value, FormattedFormat.Replacement);
        }

        /// <inheritdoc />
        public string Unformat(string value)
        {
            value.Guard(nameof(value));
            AssertFormattable(value);

            return IsUnformatted(value)
                ? value
                : FormattedFormat.Pattern.Replace(value, UnformattedFormat.Replacement);
        }

        /// <inheritdoc />
        public bool IsFormatted(string value)
        {
            value.Guard(nameof(value));

            return FormattedFormat.Pattern.IsMatch(value);
        }

        /// <inheritdoc />
        public bool IsUnformatted(string value)
        {
            value.Guard(nameof(value));

            return UnformattedFormat.Pattern.IsMatch(value);
        }

        /// <inheritdoc />
        public bool IsFormattable(string value)
        {
            return IsFormatted(value) || IsUnformatted(value);
        }

        /// <inheritdoc />
        public void AssertFormattable(string value)
        {
            if (!IsFormattable(value))
                throw new InvalidOperationException("Invalid format for this formatter.");
        }
    }
}