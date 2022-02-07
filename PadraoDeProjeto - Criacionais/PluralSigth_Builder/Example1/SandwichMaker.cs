using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PluralSigth_BuilderPattern
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder builder;
        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            builder = sandwichBuilder;
        }
        public void CreateBuilderSandwich()
        {
            builder.CreateNewSandwich();
            builder.PrepareBread();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegetables();
            builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return builder.GetSandwich();
        }
    }
}
