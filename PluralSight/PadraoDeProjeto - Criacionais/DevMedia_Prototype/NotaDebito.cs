using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype.Interface;

namespace Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype
{
    public class NotaDebito : NotaFiscal
    {
        public NotaDebito(INotaFiscal pNotaFiscal) : base(pNotaFiscal)
        {
        }

        public override NotaFiscal Clone()
        {
            return (NotaFiscal)this.MemberwiseClone();
        }

        public override NotaFiscal CopiaProfunda()
        {
            throw new NotImplementedException();
        }
    }
}
