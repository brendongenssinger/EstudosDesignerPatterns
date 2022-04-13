using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.Alura
{
    internal class TesteImposto
    {
        public static void Main(string[] args) 
        {
            
            CalcImpost();
            CalcInvestimento();
            Console.ReadKey();

        }

        private static void CalcInvestimento()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Calculo de Investimento");

            var realizadorDeInvestimento = new RealizadorDeInvestimentos();
            realizadorDeInvestimento.CalculoInvestimento(new ContaCorrente(500), TipoInvestimento.CONSERVADOR);
            realizadorDeInvestimento.CalculoInvestimento(new ContaCorrente(500), TipoInvestimento.MODERADO);
            realizadorDeInvestimento.CalculoInvestimento(new ContaCorrente(500), TipoInvestimento.ARROJADO);

        }

        private static void CalcImpost()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Calculo de imposto");
            IImpostos icms = new ICMS();
            IImpostos iss = new ISS();
            IImpostos ccc = new ICCC();
            Orcamento orcamento = new Orcamento(500.00);

            CalculadorDeImpostos calc = new CalculadorDeImpostos();

            calc.RealizaCalculo(orcamento, icms);
            calc.RealizaCalculo(orcamento, iss);
            calc.RealizaCalculo(orcamento, ccc);

            ccc.Calcula(orcamento);            
            Console.WriteLine("Finished Calculo de imposto");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
