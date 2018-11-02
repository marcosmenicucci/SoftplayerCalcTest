using System;
using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.Models;
using SoftplayerCalcTest.Services;

namespace SoftplayerCalcTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly CalculaJurosService _calc;
        
        public CalculaJurosController()
        {
            _calc = new CalculaJurosService();
        }

        // GET api/values
        [HttpGet("{initialValue}/{time}")]
        public ActionResult<string> GetCalculaJuros(double initialValue, int time)
        {
            try
            {
                return _calc.CalculaJuros(initialValue, time);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço CalculaJuros: " + ex.Message);
            }
        }
    }
}
