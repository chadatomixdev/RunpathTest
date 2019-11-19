using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Runpath.API.Controllers;
using Runpath.UnitTests.Config;
using Xunit;

namespace Runpath.UnitTests
{
    public class TestControllerTests : IClassFixture<Setup>
    {
        TestController _testController;
        ServiceProvider _serviceProvider;

        public TestControllerTests(Setup setup)
        {
            _serviceProvider = setup.ServiceProvider;
            _testController = new TestController(_serviceProvider.GetService<IConfiguration>());
        }

        [Fact]
        public void GetTestVersion()
        {
            //Act
            var okResult = _testController.Test();

            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }
    }
}