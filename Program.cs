using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Chain Of Responsability

namespace Designer_Pattern.ExecutarTypesDesigner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iniciando ChainOfResponsability.");
            var orcamento = new Orcamento() { Valor = 350, Itens = new List<object>(5) { } };
            new CalculadorDeDescontos().Calcula(orcamento);
        }
    }
}
