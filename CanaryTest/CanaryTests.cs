using Xunit;

namespace juxce.tuneage.devops.canary.tests
{
    public class CanaryTests
    {
        [Fact]
        public void HelpShouldBeMe()
        {
            var target = CanaryHelper.Help();

            Assert.Equal("Me", target );

        }
    }
}
