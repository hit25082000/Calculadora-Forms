using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        private List<double> numeros;

        private List<string> operacoes;

        public Calculadora()
        {
            numeros = new List<double>();
            operacoes = new List<string>();
        }
        public string CalcularResultado()
        {            
            while(numeros.Count() > 1)
            {
                if (operacoes.FirstOrDefault() == "+")
                {
                    numeros[0] = numeros[0] + numeros[1];
                    CalculoExecutado();
                }
                if (operacoes.FirstOrDefault() == "-")
                {
                    numeros[0] = numeros[0] - numeros[1];
                    CalculoExecutado();
                }
                if (operacoes.FirstOrDefault() == "/")
                {
                    numeros[0] = numeros[0] / numeros[1];
                    CalculoExecutado();
                }
                if (operacoes.FirstOrDefault() == "*")
                {
                    numeros[0] = numeros[0] * numeros[1];
                    CalculoExecutado();
                }
            }
            
            return numeros.FirstOrDefault().ToString();
        }

        public void AdicionarNumero(double numero)
        {
            numeros.Add(numero);
        }
        public void AdicionarOperacao(string operacao)
        {
            operacoes.Add(operacao);
        }

        private void CalculoExecutado()
        {
            numeros.RemoveAt(1);

            operacoes.RemoveAt(0);
        }              
    }
}
