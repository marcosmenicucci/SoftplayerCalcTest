using SoftplayerCalcTest.Models;
using SoftplayerCalcTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftplayerCalcTest.Controllers
{
    public class CalcController : Controller
    {
        private readonly CalcServices _calc = new CalcServices();

        [ActionName("calculajuros")]
        public string GetCalculaJuros(CalcData _calcData)
        {
            try
            {
                return _calc.GetCalculaJuros(_calcData);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço GetCalculaJuros: " + ex.Message);
            }
        }

        [ActionName("showmethecode")]
        public string GetShowMetheCode()
        {
            try
            {
                return _calc.GetShowMetheCode();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço GetShowMetheCode: " + ex.Message);
            }
        }
	}
}