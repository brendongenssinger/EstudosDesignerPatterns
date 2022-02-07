using Designer_Pattern.PadraoDeProjeto___Criacionais.DevMedia_Prototype.Model;
using Designer_Pattern.PadraoDeProjeto_Criacionais.DevMedia_Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PadraoDeProjeto___Criacionais.DevMedia_Prototype
{
    public static class ExecutarPrototype
    {
        public static void Executar()
        {
            var notaFiscal = new ModelPrototype();
            notaFiscal.NomeCliente = "Brendon";
            notaFiscal.IdCliente = 1;
            notaFiscal.TelefoneCliente = "62661664";
            notaFiscal.ValorNotaFiscal = 22.50;
            notaFiscal.EnderecoCliente = "Rua teste";
            notaFiscal.EmailCliente = "Brendon@teste";
            var cloneObject = new NotaCliente(notaFiscal).Clone();
            Console.WriteLine("Usando Designer Pattern (Prototype)");
            Console.WriteLine($"Nome:{cloneObject._notaFiscal.NomeCliente} \n ID:{cloneObject._notaFiscal.IdCliente}\nTelefone:{cloneObject._notaFiscal.TelefoneCliente}\n Valor Nota Fiscal: {cloneObject._notaFiscal.ValorNotaFiscal}\n");
            Console.ReadKey();
        }
    }
}
