using System.Diagnostics.CodeAnalysis;

namespace FluentFormatter
{
    /// <summary>
    ///     Represents an <c>object</c> that can be formattable.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMemberInSuper.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IFormattable
    {
        /// <summary>
        ///     The formatter responsible to make the format operations.
        /// </summary>
        IFormatter Formatter { get; }

        /// <summary>
        ///     The formatted representation, in <c>string</c>,
        ///     of the <c>object</c>.
        /// </summary>
        /// <returns>Its <c>string</c> representation formatted.</returns>
        string Formatted();

        /// <summary>
        ///     The unformatted representation, in <c>string</c>,
        ///     of the <c>object</c>.
        /// </summary>
        /// <returns>Its <c>string</c> representation unformatted.</returns>
        string Unformatted();
    }
}