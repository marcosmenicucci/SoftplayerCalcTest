using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftplayerCalcTest;
using SoftplayerCalcTest.Controllers;
using SoftplayerCalcTest.Models;

namespace SoftplayerCalcTest.Tests.Controllers
{
    [TestClass]
    public class CalcControllerTest
    {
        [TestMethod]
        public void GetCalculaJuros()
        {
            CalcController controller = new CalcController();
            CalcData _data = new CalcData();
            _data.initialValue = 100;
            _data.time = 5;

            string result = controller.GetCalculaJuros(_data);

            Assert.AreEqual("105,10", result);
        }

        [TestMethod]
        public void GetShowMetheCode()
        {
            CalcController controller = new CalcController();
            string result = controller.GetShowMetheCode();

            Assert.AreEqual("www.google.com.br", result);
        }
    }
}
