using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.Chain_Of_Responsability
{
    internal class DescontoPorVendaCasada : Desconto
    {
        public override IDesconto Proximo => new DescontoPorMaisDeQuinhentosReais();

        public override double Desconta(Orcamento orcamento)
        {
            if(Existe("CANETA",orcamento) || Existe("LAPIS", orcamento))
            {
                return orcamento.Valor * 0.5;
            }

            return Proximo.Desconta(orcamento);
        }


        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
