using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.Alura.Strategy
{
    public interface IImpostos
    {
        double Calcula(Orcamento orcamento);

    }
}   
