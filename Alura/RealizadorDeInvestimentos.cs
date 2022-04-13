using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.Alura
{
    public class RealizadorDeInvestimentos
    {
        public void CalculoInvestimento(ContaCorrente pContaCorrente, TipoInvestimento tipoInvestimento) 
        {
            double retorno = 0.00;
            int chance = 0;

            switch (tipoInvestimento)
            {
                case TipoInvestimento.CONSERVADOR:
                    retorno = pContaCorrente.Saldo * 0.8;
                    Console.WriteLine($"Saldo {tipoInvestimento.ToString().ToUpper()} R${retorno+pContaCorrente.Saldo}");
                    break;
                case TipoInvestimento.MODERADO:
                    
                    retorno = pContaCorrente.Saldo * 2.5;
                    Console.WriteLine($"Saldo {tipoInvestimento.ToString().ToUpper()} R${retorno + pContaCorrente.Saldo} 2.5%");
                    retorno = pContaCorrente.Saldo * 0.7;
                    Console.WriteLine($"Saldo {tipoInvestimento.ToString().ToUpper()} R${retorno + pContaCorrente.Saldo} 0.7%");

                    break;
                case TipoInvestimento.ARROJADO:
                    chance = new Random().Next(101);
                    
                        retorno = pContaCorrente.Saldo * 5;
                    Console.WriteLine($"Saldo {tipoInvestimento.ToString().ToUpper()} R${retorno + pContaCorrente.Saldo} - chance 20%");
                    retorno = pContaCorrente.Saldo * 3;                                  
                    Console.WriteLine($"Saldo {tipoInvestimento.ToString().ToUpper()} R${retorno + pContaCorrente.Saldo} - chance 30%");
                    retorno = pContaCorrente.Saldo * 0.6;                                
                    Console.WriteLine($"Saldo {tipoInvestimento.ToString().ToUpper()} R${retorno + pContaCorrente.Saldo} - chance 50%");                    
                    break;
                default:
                    Console.WriteLine($"Saldo {tipoInvestimento.ToString().ToUpper()} R${retorno + pContaCorrente.Saldo} ");
                    break;
            }
        }
    }

    public class ContaCorrente
    {
        public int Saldo { get; private set; }
        public ContaCorrente(int pSaldo)
        {
            Console.WriteLine("Saldo => "+pSaldo);
            this.Saldo = pSaldo;
        }
    }

    public enum TipoInvestimento 
    {
        CONSERVADOR,
        MODERADO,
        ARROJADO
    }
}
