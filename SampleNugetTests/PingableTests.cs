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
            var ping = new Pingable();

            // Act
            var result = ping.Pong();

            // Assert
            result.Should().BeTrue();
        }

    }
}