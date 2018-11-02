using System;
using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.Models;
using SoftplayerCalcTest.Services;

namespace SoftplayerCalcTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly ShowMeTheCodeService _show;
        
        public ShowMeTheCodeController()
        {
            _show = new ShowMeTheCodeService();
        }

        [HttpGet]
        public ActionResult<string> GetShowMetheCode()
        {
            try
            {
                return _show.ShowMetheCode();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço ShowMetheCode: " + ex.Message);
            }
        }
    }
}
