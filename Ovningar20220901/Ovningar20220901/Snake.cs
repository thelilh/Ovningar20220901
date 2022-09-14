namespace Ovningar20220901
{
    public class Snake
    {
        public int _width;
        public int _height;
        public int _randomShapes;
        private string[] _drawArray;
        public bool shouldPlay;

        public string[] drawArray
        {
            get { return _drawArray; }
            set { _drawArray = value; }
        }
        public int[,] PlayerPos { get; set; }
        public bool ShowPlayer { get; set; }


        public string[] DrawBox()
        {
            var tempArray = new string[_height];
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
                            Console.WriteLine($"x: {PlayerPos[j, 0]}, y: {PlayerPos[j, 1]}");
                            tempArray[i] += "@";
                            hasFound = true;
                        }
                    }
                    if (!hasFound)
                    {
                        if (i == 0 || i == _height - 1)
                        {
                            tempArray[i] += "#";
                        }
                        else
                        {
                            if (k == 0 || k == _width - 1)
                            {
                                tempArray[i] += "#";
                            }
                            else
                            {
                                tempArray[i] += "-";
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
                if (tempArray[placeY][placeX] == '@' || tempArray[placeY][placeX] == '#') continue;
                tempArray[placeY] = tempArray[placeY].Remove(placeX, 1).Insert(placeX, "#");
                currentSharp++;
            }
            return tempArray;
        }

        public void PrintArray(string[] thisArray)
        {
            foreach (var x in thisArray)
            {
                Console.WriteLine(x);
            }

        }

        public void Walk(int x, int y)
        {
            var newX = PlayerPos[0, 1] + x;
            var newY = PlayerPos[0, 0] + y;
            Console.WriteLine($"moveX = {x}, moveY = {y}, PlayerY = {newY}, PlayerX = {newX}");
            if ((newX > 0 && newX < _width) || (newY > 0 && newY < _height))
            {
                if (drawArray[newY][newX] != '#')
                {
                    for (var i = PlayerPos.GetLength(0) - 1; i > 0; i--)
                    {
                        PlayerPos[i, 0] = PlayerPos[i - 1, 0];
                        PlayerPos[i, 1] = PlayerPos[i - 1, 1];
                    }
                    PlayerPos[0, 0] = newY;
                    PlayerPos[0, 1] = newX;
                }
            }

        }
    }
}
