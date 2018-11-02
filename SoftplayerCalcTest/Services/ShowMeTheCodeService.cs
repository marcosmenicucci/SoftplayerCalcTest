using SoftplayerCalcTest.Models;
using System;

namespace SoftplayerCalcTest.Services
{
    public class ShowMeTheCodeService
    {
        public string ShowMetheCode()
        {
            try
            {
                return "https://github.com/marcosmenicucci/SoftplayerCalcTest";
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço ShowMetheCode: " + ex.Message);
            }
        }
    }
}