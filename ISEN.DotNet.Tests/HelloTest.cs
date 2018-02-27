using System;
using Xunit;
using ISEN.DotNet.Library;

namespace ISEN.DotNet.Tests
{
    public class HelloTest
    {
        [Fact]
        public void World()
        {
            var result = Hello.World;
            var expected = "Hello, World";
            Assert.True(result == expected);

        }
        [Fact]
        public void Greet(){
            var result = Hello.Greet("wesh");
            Assert.StartsWith("Salut BG wesh, il est", result);
        }
        [Fact]
        public void GreetUpper(){
            var result = Hello.GreetUpper("KALL");
            Assert.StartsWith("Salut BG KALL, il est", result);
        }
    }
}
