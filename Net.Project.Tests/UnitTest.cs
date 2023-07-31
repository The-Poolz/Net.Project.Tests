using Xunit;
using FluentAssertions;

namespace Net.Project.Tests
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            const string message = "hello world!";

            message.Should().Be(message);
        }
    }
}