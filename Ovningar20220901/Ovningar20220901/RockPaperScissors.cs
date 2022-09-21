namespace Ovningar20220901
{
    public class RockPaperScissors
    {
        protected static int cursTop = Console.CursorTop;
        protected static int cursLeft = Console.CursorLeft;
        public enum Choices
        {
            Rock = 0,
            Paper = 1,
            Scissors = 2
        }

        public enum Scenarios
        {
            Win,
            Lose,
            Draw
        }

        private string _name;
        private int[] _pos;
        private int _score;
        private Choices _choices;

        public Choices SetChoices
        {
            get { return _choices; }
            set { _choices = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public int[] Pos
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Print()
        {
            Console.SetCursorPosition(cursLeft + Pos[0], cursTop + Pos[1]);
            Console.Write($"{Name}: {Score}");
        }

        public static Scenarios IsWin(Choices one, Choices two)
        {
            if (one == two)
            {
                return Scenarios.Draw;
            }

            if (one == Choices.Rock && two == Choices.Scissors)
            {
                return Scenarios.Win;
            }

            if (one == Choices.Paper && two == Choices.Rock)
            {
                return Scenarios.Win;
            }

            if (one == Choices.Scissors && two == Choices.Paper)
            {
                return Scenarios.Win;
            }
            return Scenarios.Lose;
        }
    }
}
