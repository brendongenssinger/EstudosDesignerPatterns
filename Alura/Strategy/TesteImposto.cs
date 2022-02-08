using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.Alura.Strategy
{
    internal class TesteImposto
    {
        public static void Main(string[] args) 
        {
            IImpostos icms = new ICMS();
            IImpostos iss = new ISS();
            IImpostos ccc = new ICCC();
            Orcamento orcamento = new Orcamento(500.00);

            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            calc.RealizaCalculo(orcamento,icms);
            calc.RealizaCalculo(orcamento, iss);
            calc.RealizaCalculo(orcamento, ccc);

            ccc.Calcula(orcamento);

        }
    }
}
