using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBásica.winformsapp
{
    public class Calculadora
    {
        public decimal primeiroNumero;
        public decimal segundoNumero;
        public char operacao;

        public string Calcular()
        {
            decimal resultado = 0;

            switch (operacao)
            {
                case '+': resultado = primeiroNumero + segundoNumero; break;
                case '-': resultado = primeiroNumero - segundoNumero; break;
                case '*': resultado = primeiroNumero * segundoNumero; break;
                case '/': resultado = primeiroNumero / segundoNumero; break;
            }

            return Math.Round(resultado, 2).ToString();
        }

        public void Limpar()
        {
            primeiroNumero = 0;
            segundoNumero = 0;
            operacao = char.MinValue;
        }
    }
}
