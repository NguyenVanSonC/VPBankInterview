using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace VP.BackgroundJobManager.Pages;

public class Index_Tests : BackgroundJobManagerWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
