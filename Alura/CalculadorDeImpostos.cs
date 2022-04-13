﻿using System;

namespace Designer_Pattern.Alura
{
    internal class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento,IImpostos imposto) 
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}