using System.Collections.Generic;

namespace Designer_Pattern
{
    public class Orcamento
    {
        public int Valor { get; internal set; }
        public List<Item> Itens { get; set; }
    }

    public class Item
    {
        public string Nome { get; set; }
    }
}