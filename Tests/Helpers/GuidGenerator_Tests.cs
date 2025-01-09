using Business.Helpers;

namespace Tests.Helpers;
public class GuidGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnGuidAsString()
    {
        var result = GuidGenerator.Generate();

        Assert.NotNull(result);
        Assert.True(Guid.TryParse(result, out _));
    }
}
