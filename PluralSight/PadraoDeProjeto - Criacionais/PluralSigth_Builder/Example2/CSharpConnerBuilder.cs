using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PadraoDeProjeto___Criacionais.PluralSigth_Builder.Example2
{
    // Create Builder
    /*
     * 
     **/
    public class Director
    {

        public void Construct(IBuilder builder)
        {
            builder.DoIT();
        }
    }
    public interface IBuilder
    {
        void DoIT();
    }
    public class BuilderA : IBuilder
    {
        public void DoIT()
        {
            Console.WriteLine("Builder A");
        }
    }
    public class BuilderB : IBuilder
    {
        public void DoIT()
        {
            Console.WriteLine("Builder B");
        }
    }

    public class VoidMaind
    {
        void Main()
        {
            var d = new Director() ;
            var build = new BuilderA();
            d.Construct(build);           
        }
    }
}
