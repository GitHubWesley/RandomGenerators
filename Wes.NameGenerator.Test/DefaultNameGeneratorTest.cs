using Microsoft.VisualStudio.TestPlatform.Utilities;
using Wes.NameGenerator.NameCollections;
using Xunit.Abstractions;

namespace Wes.NameGenerator.Test;

public class DefaultNameGeneratorTest
{
    private readonly ITestOutputHelper _output;

    public DefaultNameGeneratorTest(ITestOutputHelper output)
    {
        this._output = output;
    }

    [Fact]
    public void Generate()
    {
        var generator = new DefaultNameGenerator(new ChineseNameCollection());
        for (int i = 0; i < 50; i++)
        {
            var name = generator.GenerateFullName();
            _output.WriteLine(name);
        }
    }
}