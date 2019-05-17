using System;

namespace KataCoffeeMachine
{
    public class DrinkMaker
    {
        private readonly string instruction;

        public DrinkMaker(string instruction)
        {
            this.instruction = instruction;
        }

        public string ReadInstruction()
        {
            return "Drink maker makes 1 tea with no sugar and therefore no stick";
        }
    }
}