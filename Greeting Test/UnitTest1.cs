using GreetingApp;
using Xunit.Abstractions;

namespace Greeting_Test
{
    public class GreetingTest
    {
        private readonly Greeting _sut;
        private readonly ITestOutputHelper _output;

        public GreetingTest(ITestOutputHelper output)
        {
            _output = output;
            _sut = new Greeting();
        }

        [Fact]
        public void SimpleGreet()
        {
            var result = _sut.Greet("Bob");
            Assert.Equal("Hello, Bob.", result);
        }

        [Fact]

        public void SimpleGreetNull() 
        {
            
            Assert.Equal("Hello, my friend.",_sut.Greet(null));
        }

        [Fact]
        public void AllCapitalGreet()
        {
            var result = _sut.Greet("JERRY");
            Assert.Equal("HELLO, JERRY!", result);
        }

        [Fact]
        public void GreetTwoNames()
        {
            var result = _sut.Greet("Jill", "Jane");
            Assert.Equal("Hello, Jill and Jane.", result);
        }

        [Fact]
        public void GreetMultipleNames()
        {
            var result = _sut.Greet("Amy", "Brian", "Charlotte");
            Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
        }

        [Fact]
        public void Sandbox()
        {
            var result = _sut.Greet("Andrea", "Paperino", "Pluto");
            _output.WriteLine(result);
        }
    }
}