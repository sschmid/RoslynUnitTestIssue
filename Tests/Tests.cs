using MyConsoleApp;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class Tests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Tests(ITestOutputHelper testOutputHelper) => _testOutputHelper = testOutputHelper;

        [Fact]
        public void GetAttributes()
        {
            foreach (var attribute in Helper.GetAttributes())
                _testOutputHelper.WriteLine(attribute.ToString());
        }
    }
}
