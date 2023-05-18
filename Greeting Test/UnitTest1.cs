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
    }
}