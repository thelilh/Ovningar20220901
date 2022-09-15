namespace Ovningar20220901
{
    public class Snake
    {
        public int _width;
        public int _height;
        public int _randomShapes;
        private string[,] _drawArray;
        public bool shouldPlay;

        public string[,] drawArray
        {
            get { return _drawArray; }
            set { _drawArray = value; }
        }
        public int[,] PlayerPos { get; set; }
        public bool ShowPlayer { get; set; }


        public string[,] DrawBox()
        {
            var tempArray = new string[_height, 1];
            var rand = new Random();
            for (var i = 0; i < _height; i++)
            {
                for (var k = 0; k < _width; k++)
                {
                    bool hasFound = false;
                    //Console.WriteLine($"PlayerPos.Length: {PlayerPos.GetLength(0)}, PlayerPos.Rank: {PlayerPos.Rank}");
                    for (var j = 0; j < PlayerPos.GetLength(0); j++)
                    {
                        if (k == PlayerPos[j, 1] && i == PlayerPos[j, 0])
                        {
                            tempArray[i, 0] += "@";
                            hasFound = true;
                        }
                    }
                    if (!hasFound)
                    {
                        if (i == 0 || i == _height - 1)
                        {
                            tempArray[i, 0] += "#";
                        }
                        else
                        {
                            if (k == 0 || k == _width - 1)
                            {
                                tempArray[i, 0] += "#";
                            }
                            else
                            {
                                tempArray[i, 0] += "X";
                            }
                        }
                    }
                }
            }

            var currentSharp = 0;
            if (_randomShapes <= 0) return tempArray;
            while (currentSharp < _randomShapes)
            {
                var placeX = rand.Next(1, _width - 1);
                var placeY = rand.Next(1, _height - 1);
                if (tempArray[placeY, 0][placeX] == '@' || tempArray[placeY, 0][placeX] == '#') continue;
                tempArray[placeY, 0] = tempArray[placeY, 0].Remove(placeX, 1).Insert(placeX, "#");
                currentSharp++;
            }
            return tempArray;
        }

        public void PrintArray(string[,] thisArray)
        {
            bool falseRand = false;
            foreach (var x in thisArray)
            {
                foreach (var y in x)
                {
                    Console.ResetColor();
                    if (y == '@')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (y == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        if (falseRand)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        }
                    }
                    falseRand = !falseRand;
                    Console.Write(y);
                }
                Console.Write("\n");
            }

        }

        public void Walk(int x, int y)
        {
            var newX = PlayerPos[0, 1] + x;
            var newY = PlayerPos[0, 0] + y;
            if ((newX <= 0 || newX >= _width) && (newY <= 0 || newY >= _height)) return;
            if (drawArray[newY, 0][newX] == '#' || drawArray[newY, 0][newX] == '@') return;
            for (var i = PlayerPos.GetLength(0) - 1; i > 0; i--)
            {
                PlayerPos[i, 0] = PlayerPos[i - 1, 0];
                PlayerPos[i, 1] = PlayerPos[i - 1, 1];
            }
            PlayerPos[0, 0] = newY;
            PlayerPos[0, 1] = newX;
            Console.WriteLine($"moveX = {x}, moveY = {y}, PlayerY = {newY}, PlayerX = {newX}");
        }
    }
}
