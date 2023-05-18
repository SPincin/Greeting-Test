using GreetingApp;

namespace Greeting_Test
{
    public class GreetingTest
    {
        private readonly Greeting _sut;

        public GreetingTest()
        {
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
    }
}