using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype.Interface;
namespace Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype
{
    public abstract class NotaFiscal 
    {
        public INotaFiscal _notaFiscal;
        public NotaFiscal(INotaFiscal pNotaFiscal)
        {
            _notaFiscal = pNotaFiscal;            
        }

        public abstract NotaFiscal Clone();
        public abstract NotaFiscal CopiaProfunda();
    }
}
