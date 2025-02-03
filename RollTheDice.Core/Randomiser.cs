namespace RollTheDice.Core
{
    public class Randomiser
    {
        public int MaxValue { get; set; }
        public Randomiser(int value)
        {
            MaxValue = value + 1;
        }
        public int RollTheValue()
        {
            int finalValue = 0;
            int minValue = 1;

            Random random = new Random();

            finalValue = random.Next(minValue,MaxValue);
            return finalValue;
        }
    }
}
