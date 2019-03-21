using System;
using FluentFormatter.Test.Assets;
using Xunit;

namespace FluentFormatter.Test
{
    public class FormatterTests
    {
        private const string FormattedValue = "111.111.111-11";
        private const string UnformattedValue = "11111111111";
        private const string InvalidFormat = "1111111";

        [Theory]
        [InlineData(FormattedValue)]
        [InlineData(UnformattedValue)]
        public void Given_Valid_Format_Value_Should_Not_Throw_Exception_In_AssertFormattable(string value)
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            formatter.AssertFormattable(value);
        }

        [Theory]
        [InlineData(FormattedValue)]
        [InlineData(UnformattedValue)]
        public void Given_Valid_Format_Value_Should_Be_True_In_IsFormattable(string value)
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.True(formatter.IsFormattable(value));
        }

        [Fact]
        public void Given_Empty_Value_Should_Throw_Exception_In_Format()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => formatter.Format(""));
        }

        [Fact]
        public void Given_Empty_Value_Should_Throw_Exception_In_IsFormatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => formatter.IsFormatted(""));
        }

        [Fact]
        public void Given_Empty_Value_Should_Throw_Exception_In_IsUnformatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => formatter.IsUnformatted(""));
        }

        [Fact]
        public void Given_Empty_Value_Should_Throw_Exception_In_Unformat()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => formatter.Unformat(""));
        }

        [Fact]
        public void Given_Formatted_Value_Should_Be_False_In_IsUnformatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.False(formatter.IsUnformatted(FormattedValue));
        }

        [Fact]
        public void Given_Formatted_Value_Should_Be_True_In_IsFormatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.True(formatter.IsFormatted(FormattedValue));
        }

        [Fact]
        public void Given_Formatted_Value_Should_Be_Unformatted_In_Unformat()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act
            var formattedTest = formatter.Unformat(FormattedValue);

            // Assert
            Assert.Equal(UnformattedValue, formattedTest);
        }

        [Fact]
        public void Given_Formatted_Value_Should_Continue_Formatted_In_Format()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act
            var formattedTest = formatter.Format(FormattedValue);

            // Assert
            Assert.Equal(FormattedValue, formattedTest);
        }

        [Fact]
        public void Given_Invalid_Format_Value_Should_Be_False_In_IsFormattable()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.False(formatter.IsFormattable(InvalidFormat));
        }

        [Fact]
        public void Given_Invalid_Format_Value_Should_False_In_IsFormatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.False(formatter.IsFormatted(InvalidFormat));
        }

        [Fact]
        public void Given_Invalid_Format_Value_Should_False_In_IsUnformatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.False(formatter.IsUnformatted(InvalidFormat));
        }

        [Fact]
        public void Given_Invalid_Format_Value_Should_Throw_Exception_In_AssertFormattable()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => formatter.AssertFormattable(InvalidFormat));
        }

        [Fact]
        public void Given_Invalid_Format_Value_Should_Throw_Exception_In_Format()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => formatter.Format(InvalidFormat));
        }

        [Fact]
        public void Given_Invalid_Format_Value_Should_Throw_Exception_In_Unformat()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => formatter.Unformat(InvalidFormat));
        }

        [Fact]
        public void Given_Null_Value_Should_Throw_Exception_In_Format()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => formatter.Format(null));
        }

        [Fact]
        public void Given_Null_Value_Should_Throw_Exception_In_IsFormatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => formatter.IsFormatted(null));
        }

        [Fact]
        public void Given_Null_Value_Should_Throw_Exception_In_IsUnformatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => formatter.IsUnformatted(null));
        }

        [Fact]
        public void Given_Null_Value_Should_Throw_Exception_In_Unformat()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => formatter.Unformat(null));
        }

        [Fact]
        public void Given_Unformatted_Value_Should_Be_False_In_IsFormatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.False(formatter.IsFormatted(UnformattedValue));
        }

        [Fact]
        public void Given_Unformatted_Value_Should_Be_Formatted_In_Format()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act
            var formattedTest = formatter.Format(UnformattedValue);

            // Assert
            Assert.Equal(FormattedValue, formattedTest);
        }

        [Fact]
        public void Given_Unformatted_Value_Should_Be_True_In_IsUnformatted()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act and Assert
            Assert.True(formatter.IsUnformatted(UnformattedValue));
        }

        [Fact]
        public void Given_Unformatted_Value_Should_Continue_Unformatted_In_Unformat()
        {
            // Arrange
            IFormatter formatter = new TestedFormatter();

            // Act
            var formattedTest = formatter.Unformat(UnformattedValue);

            // Assert
            Assert.Equal(UnformattedValue, formattedTest);
        }
    }
}