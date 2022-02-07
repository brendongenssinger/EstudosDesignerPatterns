using System;

namespace Designer_Pattern.Adapter
{
    /**
     * USO DO ADAPTER PATTERN
     * 
     * 
     */
    public class DesignerPattern_Adapter
    {
        public static void TestarEssaClasse() // Cliente 
        {
            /*
             * Colabora com os objetos em conformidade com a interface Target.
             * */
            ITarget target = new Adapter();
            target.Request();
            Console.Read();
        }
    }

    interface ITarget
    {
        void Request();
    }

    class Target : ITarget // (ALVO) Define a interface do domínio específico que o cliente utiliza.
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    // Adapta a interface Adaptee para a interface da classe Target.
    class Adapter : Target 
    {
        /**
         * Está classe ela adpta entre a interface ITarget com a IAdaptee
         */
        private readonly Adaptee _adpAdaptee = new Adaptee();
        public override void Request()
        {
            _adpAdaptee.SpecificRequest();
        }
    }


    //Define uma interface existente que necessita ser adaptada.
    interface IAdaptee
    {
        void SpecificRequest();
    }
    class Adaptee : IAdaptee
    {  
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }

}
