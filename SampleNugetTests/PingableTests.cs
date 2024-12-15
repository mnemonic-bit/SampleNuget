using FluentAssertions;
using SampleNuget;

namespace SampleNugetTests
{
    public class PingableTests
    {

        [Fact]
        public void Pong_ShouldReturnTrue()
        {
            // Arrange
            var pingable = new Pingable();

            // Act
            var result = pingable.Ping();

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Ping_ShoundReturnTrue()
        {
            // Arrange
            var pingable = new Pingable();

            // Act
            var result = pingable.Pong();

            // Assert
            result.Should().BeFalse();
        }

    }
}