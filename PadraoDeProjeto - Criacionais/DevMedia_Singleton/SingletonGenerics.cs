using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PadraoDeProjeto___Criacionais.PluralSigth_Singleton
{
    public sealed class SingletonGenerics<T> where T: class, new ()
    {
        private static T instance;
        public static T Instance()
        {
            lock (typeof(T))
                if (instance is null) instance = new T();
            return instance;
        }
        private SingletonGenerics()
        {

        }
    }
    public class Cadeira
    {
        public int Quantidade { get; set; }
    }
    public class Mesa
    {
        public string Tamanho { get; set; }
    }

    public class VoidMain2
    {
        public static void Main()
        {            
            Cadeira _cad = SingletonGenerics<Cadeira>.Instance();
            _cad.Quantidade = 5;
            Mesa _mesa = SingletonGenerics<Mesa>.Instance();
            _mesa.Tamanho = "500metros";
            Console.WriteLine($"Using Single Generics\n Quantidade {_cad.Quantidade} \n Tamanho:{_mesa.Tamanho} \n");
        }
    }

}
