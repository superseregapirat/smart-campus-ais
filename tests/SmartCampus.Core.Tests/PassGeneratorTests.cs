using SmartCampus.Core.Services;

namespace SmartCampus.Core.Tests;

public class PassGeneratorTests
{
    public async Task GeneratePass_ShouldSet60SecondsExpiration()
    {
        var generator = new PassGenerator();
        var pass = await generator.GenerateDynamicPassAsync(Guid.NewGuid());
    }
}
