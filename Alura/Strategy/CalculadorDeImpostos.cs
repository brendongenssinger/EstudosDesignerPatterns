using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.Alura.Strategy
{
    internal class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento,IImpostos imposto) 
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}
