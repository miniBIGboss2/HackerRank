using System.Collections.Generic;
using Xunit;

namespace SherlockAndTheValidString.Tests
{
    public class ValidateStringTests
    {
        [Fact]
        public void FirstEvaluation_ShortStringShouldPass()
        {
            // Arrange
            var expected = true;

            // Act
            var dictionary = new Dictionary<char, int>
            {
                {'a', 2},
                {'s', 2},
                {'d', 2}
            };

            var actual = ValidateString.FirstEvaluation(dictionary);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}