using System.Collections.Generic;

namespace Designer_Pattern
{
    public class Orcamento
    {
        public int Valor { get; internal set; }
        public List<object> Itens { get; set; }
    }
}