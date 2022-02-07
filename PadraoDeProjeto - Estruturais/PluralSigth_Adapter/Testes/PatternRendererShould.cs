using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Designer_Pattern.PluralSigth_Adapter.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Designer_Pattern.Adapter.Testes
{
    [TestClass]
    public class PatternRendererShould
    {
        public static void Exec_Teste_PatternRendererShould()
        {
            
        }

        [TestMethod]
        public void RenderOnePatter()
        {
            var myRenderer = new PatternRenderer();
            var myList = new List<Pattern>
            {
                new Pattern {Id = 1, Name = "Brendon", Description = "Pattern one Description"},
                new Pattern {Id = 2, Name = "Pattern Two", Description = "Pattern two Description"}

            };
            string result = myRenderer.ListPatterns(myList);
            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(myList.Count+2, lineCount);

        }

        [TestMethod]
        public void RenderTwoPatter()
        {
            var myRenderer = new PatternRenderer();
            var myList = new List<Pattern>
            {
                new Pattern {Id = 1, Name = "Brendon", Description = "Pattern one Description"},
                new Pattern {Id = 2, Name = "Pattern Two", Description = "Pattern two Description"}

            };
            string result = myRenderer.ListPatterns(myList);
            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(myList.Count + 2, lineCount);

        }

    }
}