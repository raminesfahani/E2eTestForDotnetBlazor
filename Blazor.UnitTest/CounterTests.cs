using BlazorTestSample.Pages;

namespace Blazor.UnitTest
{
    public class CounterTests : TestContext
    {
        [Fact]
        public void RenderCounter_ShouldCounterStartsAtZero()
        {
            // Arrange
            var cut = RenderComponent<Counter>();

            // Assert
            cut.Find("p").TextContent.MarkupMatches("Current count: 0");
        }

        [Fact]
        public void RenderCounter_ClickingButton_ShouldIncrementsCounter()
        {
            // Arrange
            var cut = RenderComponent<Counter>();

            // Act
            cut.Find("button").Click();

            // Assert
            cut.Find("p").TextContent.MarkupMatches("Current count: 1");
        }
    }
}