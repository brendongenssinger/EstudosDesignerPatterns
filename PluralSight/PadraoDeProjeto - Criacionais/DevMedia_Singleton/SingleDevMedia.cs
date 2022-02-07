using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PadraoDeProjeto___Criacionais.PluralSigth_Singleton
{
    public sealed class SingleDevMedia
    {
        public static readonly SingleDevMedia _instancia = new SingleDevMedia();
        private SingleDevMedia(){}
        public static SingleDevMedia Instance
        {
            get
            {
                return _instancia;
            }
        }
        public int Quantidade
        {
            get;set;
        }
    }

    public class VoidMain
    {
        public static void Main()
        {
            SingleDevMedia _singe = SingleDevMedia.Instance;
            _singe.Quantidade = 1;
            var novo = SingleDevMedia.Instance;
            novo.Quantidade = 3;
            var novo1 = SingleDevMedia.Instance;
            novo1.Quantidade=4;
            Console.WriteLine("Using Designer Patter (Single)");
            Console.WriteLine($"Single {_singe.Quantidade}");
            Console.WriteLine($"Single {novo.Quantidade}");
            Console.WriteLine($"Single {novo1.Quantidade}");
            Console.ReadLine();

        }
    }
}
