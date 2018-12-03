using Xunit;

namespace TDD.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Generate_FirstNumberOne_True()
        {
            var numbers = TDD.Generator.Generate();
        }
    }
}