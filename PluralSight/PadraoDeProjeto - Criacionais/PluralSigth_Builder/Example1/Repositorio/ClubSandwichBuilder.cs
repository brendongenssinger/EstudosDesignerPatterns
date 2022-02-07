using System;
using System.Collections.Generic;

namespace Designer_Pattern.PluralSigth_BuilderPattern
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = false;
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.Cheedar;
            sandwich.MeatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> {"Tomate","Onion" };
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
        }
    }
}