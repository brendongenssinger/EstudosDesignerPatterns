using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype.Interface
{
    public interface INotaFiscal
    {
        int IdCliente { get; set; }
        string NomeCliente { get; set; }
        string EmailCliente { get; set; }
        string TelefoneCliente { get; set; }
        string EnderecoCliente { get; set; }
        double ValorNotaFiscal { get; set; }
    }
}
