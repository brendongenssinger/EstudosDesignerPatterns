using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public override IDesconto Proximo => new SemDesconto();
        public override double Desconta(Orcamento orcamento)
        {
            if(orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
