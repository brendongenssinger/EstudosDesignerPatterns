using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern
{
    public class DescontoPorCincoItens : Desconto
    {
        public override IDesconto Proximo => new DescontoPorMaisDeQuinhentosReais();

        public override double Desconta(Orcamento orcamento) 
        {
            if (orcamento.Itens.Count >= 5) 
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
