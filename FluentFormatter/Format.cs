using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace FluentFormatter
{
    /// <inheritdoc />
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class Format : IFormat
    {
        /// <summary>
        ///     Constructs a format.
        /// </summary>
        /// <param name="pattern">The regex pattern format.</param>
        /// <param name="replacement">The replacement pattern.</param>
        /// <param name="options">
        ///     The <see cref="RegexOptions" />. The <see cref="RegexOptions.Compiled" /> is default.
        /// </param>
        public Format(string pattern, string replacement, RegexOptions options = RegexOptions.Compiled)
        {
            Pattern = new Regex(pattern, options);
            Replacement = replacement;
        }

        /// <inheritdoc />
        public Regex Pattern { get; }

        /// <inheritdoc />
        public string Replacement { get; }
    }
}