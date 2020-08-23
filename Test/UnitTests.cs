using BeOpen.iiko.Back.Temperature.Model;
using BeOpen.iiko.Back.Temperature.View;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TemperatureService_GetTemperatureInfo_ShouldRetrieveData()
        {
            // Arrange
            TemperatureService service = new TemperatureService();

            // Act
            var resp = service.GetTemperatureData();

            // Assert
            resp.Should().NotBeNull();
            resp.Should().NotBeEmpty();
        }
    }
}
