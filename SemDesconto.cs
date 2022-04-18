namespace Designer_Pattern
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}