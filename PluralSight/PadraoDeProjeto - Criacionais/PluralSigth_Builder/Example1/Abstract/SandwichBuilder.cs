﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PluralSigth_BuilderPattern
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;
        public Sandwich GetSandwich()
        {
            return sandwich;
        }      
        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }
        public abstract void AddCondiments();
        public abstract void ApplyVegetables();
        public abstract void ApplyMeatAndCheese();
        public abstract void PrepareBread();
    }
}
