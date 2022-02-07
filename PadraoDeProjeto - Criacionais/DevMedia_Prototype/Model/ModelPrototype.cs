using Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PadraoDeProjeto___Criacionais.DevMedia_Prototype.Model
{
    public class ModelPrototype : INotaFiscal
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public double ValorNotaFiscal { get; set; }
    }
}
