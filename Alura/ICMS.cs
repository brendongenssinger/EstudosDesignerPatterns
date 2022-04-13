using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.Alura
{
    internal class ICMS : IImpostos
    {
        public double Calcula(Orcamento orcamento)
        {            
            return orcamento.Valor * 0.1;
        }
    }
}
