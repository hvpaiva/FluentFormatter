namespace FluentFormatter.Test.Assets
{
    public static class TestFormats
    {
        public static IFormat Formatted => new Format(@"^(\d{3})[.](\d{3})[.](\d{3})-(\d{2})$", "$1.$2.$3-$4");
        
        public static IFormat Unformatted => new Format(@"^(\d{3})(\d{3})(\d{3})(\d{2})$", "$1$2$3$4");
    }
}