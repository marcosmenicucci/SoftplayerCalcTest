using SoftplayerCalcTest.Models;
using System;

namespace SoftplayerCalcTest.Services
{
    public class CalculaJurosService
    {
        const Double interest = 0.01;

        public string CalculaJuros(double initialValue, int time)
        {
            try
            {
                string result = string.Empty;
                result = (initialValue * Math.Pow(interest + 1, time)).ToString("n2"); 
                return result;
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro no serviço GetCalculaJuros: " + ex.Message);
            }
        }
    }
}