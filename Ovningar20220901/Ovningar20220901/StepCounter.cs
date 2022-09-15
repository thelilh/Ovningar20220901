namespace Ovningar20220901
{
    public class StepCounter
    {
        private int counter;

        public void Step()
        {
            counter++;
        }

        public void Reset()
        {
            counter = 0;
            Console.WriteLine("Stegräknaren är nu nollställd.");
        }

        public override string ToString()
        {
            return $"Du har gått {counter} steg";
        }
    }
}
