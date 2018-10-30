using SoftplayerCalcTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftplayerCalcTest.Services
{
    public class CalcServices
    {
        const Double interest = 0.01;

        public string GetCalculaJuros(CalcData _calcData)
        {
            try
            {
                string result = string.Empty;
                result = (_calcData.initialValue * Math.Pow(interest + 1, _calcData.time)).ToString("n2"); 
                return result;
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço GetCalculaJuros: " + ex.Message);
            }
        }

        public string GetShowMetheCode()
        {
            try
            {
                return "www.google.com.br";
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço GetShowMetheCode: " + ex.Message);
            }
        }
    }
}