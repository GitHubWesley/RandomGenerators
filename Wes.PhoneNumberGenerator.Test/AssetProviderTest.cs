using Xunit.Abstractions;

namespace Wes.PhoneNumberGenerator.Test;

public class AssetProviderTest
{
    private readonly ITestOutputHelper _output;

    public AssetProviderTest(ITestOutputHelper output)
    {
        _output = output;
    }


    [Fact]
    public void Test1()
    {
        var results = new AssetProvider().GlobalContryCodes;
        var results2 = new AssetProvider().UsAreaCodeDtos;
        var result3 = new USTelephoneNumberGenerator().Generate();
    }
}