using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento) 
        {
            IDesconto d1 = new DescontoPorCincoItens();

            return d1.Desconta(orcamento);
        }
    }
}
