using Aequitas.Core;

namespace Aequitas.UnitTests;

public class BuildInfoTests
{
    [Fact]
    public void ProductName_is_set()
    {
        BuildInfo.ProductName.Should().Be("Aequitas Research");
    }
}
