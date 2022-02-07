using Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype;
using Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype
{
    public class NotaCliente : NotaFiscal
    {
        public NotaCliente(INotaFiscal pNotaFiscal) : base(pNotaFiscal)
        {
        }

        //Classe utilizada para clonar objetos.
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
