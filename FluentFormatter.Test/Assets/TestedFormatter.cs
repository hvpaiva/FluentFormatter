namespace FluentFormatter.Test.Assets
{
    public class TestedFormatter : Formatter
    {
        public TestedFormatter() : base(TestFormats.Formatted, TestFormats.Unformatted)
        {
        }
    }
}