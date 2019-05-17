using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataCoffeeMachine
{
    [TestClass]
    public class DrinkMakerTest
    {
        [TestMethod]
        public void Drink_maker_makes_one_tea_with_one_sugar_and_one_stick()
        {
            string instruction = "T::";

            DrinkMaker drinkMaker = new DrinkMaker(instruction);
            string result = drinkMaker.ReadInstruction();

            result.Should().Be("Drink maker makes 1 tea with no sugar and therefore no stick");
        }
    }
}
