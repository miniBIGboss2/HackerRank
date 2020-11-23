using  Xunit;
using static UtopianTree.GrowTree;

namespace UtopianTree.Tests
{
    public class UtopianTreeTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(4, 7)]
        public void UtopianTree_TestCaseShouldPass(int input, int expected)
        {
            // Arrange

            // Act
            var actual = SimulateGrow(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}