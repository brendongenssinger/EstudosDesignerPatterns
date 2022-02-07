using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PluralSigth_BuilderPattern
{
    public static class ExecutarProgramBuilderPattern
    {
        /*
         * 
         * 
         */

        public static void _ExecutarProgramBuilderPattern()
        {
            Console.WriteLine("Using Designer Pattern (Builder)");
            var sandwich1 = new SandwichMaker(new MySandwichBuilder());
            sandwich1.CreateBuilderSandwich();
            var sandw1 = sandwich1.GetSandwich();
            sandw1.Display();                              
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
