using System.Text.RegularExpressions;

namespace FluentFormatter
{
    /// <summary>
    ///     Represents a format.
    /// </summary>
    public interface IFormat
    {
        /// <summary>
        ///     The format pattern in Regex.
        /// </summary>
        Regex Pattern { get; }

        /// <summary>
        ///     The replacement format.
        /// </summary>
        string Replacement { get; }
    }
}