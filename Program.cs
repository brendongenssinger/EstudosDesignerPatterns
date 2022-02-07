using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Designer_Pattern.Adapter.Testes;
using Designer_Pattern.Bridge;
using Designer_Pattern.PadraoDeProjeto___Criacionais.DevMedia_Prototype;
using Designer_Pattern.PadraoDeProjeto___Criacionais.PluralSigth_Singleton;
using Designer_Pattern.PluralSigth_BuilderPattern;
namespace Designer_Pattern.ExecutarTypesDesigner
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PadroesCriacionais();
            PadroesEstruturais();
            PadroesComportamentais();          
            
            Console.ReadKey();
        }

        private static void PadroesComportamentais()
        {
            //ExecutarPoker._ExecutarPoker();
        }

        private static void PadroesEstruturais()
        {
            PatternRendererShould.Exec_Teste_PatternRendererShould(); // Adapter
            ExecutarProgram.ExecutarProgramMethod(); // Bridge            
        }

        private static void PadroesCriacionais()
        {
            ExecutarProgramBuilderPattern._ExecutarProgramBuilderPattern(); //Builder
            VoidMain.Main(); // Single
            VoidMain2.Main();// Single 2
            ExecutarPrototype.Executar(); //Prototype {Um pouco mais complexo, usa a opção de clone de objetos.}
        }
    }
}
