namespace Designer_Pattern
{
    public abstract class Desconto : IDesconto
    {
        public abstract IDesconto Proximo { get; }

        public abstract double Desconta(Orcamento orcamento);        
    }
}