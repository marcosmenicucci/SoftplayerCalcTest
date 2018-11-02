using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.Controllers;
using SoftplayerCalcTest.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("107,10")]
        [InlineData("109,10")]
        [InlineData("105,10")]
        public void TestCalculaJuros(string value)
        {
            CalculaJurosController controller = new CalculaJurosController();
            CalculaJuros _data = new CalculaJuros();
            _data.initialValue = 100.00;
            _data.time = 5;

            ActionResult<string> result = controller.GetCalculaJuros(_data.initialValue, _data.time);

            Assert.False(!result.Value.Equals(value), $"{value} : Esse valor final está errado.");
        }

        [Theory]
        [InlineData("https://github.com/marcosmenicucci/SoftplayerCalcTest1")]
        [InlineData("https://github.com/marcosmenicucci/SoftplayerCalcTest12")]
        [InlineData("https://github.com/marcosmenicucci/SoftplayerCalcTest")]
        public void TestShowMetheCode(string url)
        {
            ShowMeTheCodeServiceController controller = new ShowMeTheCodeServiceController();
            ActionResult<string> result = controller.GetShowMetheCode();

            Assert.False(!result.Value.Equals(url), $"{url} : Essa url está invalida.");
        }
    }
}
