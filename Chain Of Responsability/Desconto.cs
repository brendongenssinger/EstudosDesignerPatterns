namespace Designer_Pattern
{
    public abstract class Desconto : IDesconto
    {
        public virtual IDesconto Proximo { get; }

        public abstract double Desconta(Orcamento orcamento);        
    }
}