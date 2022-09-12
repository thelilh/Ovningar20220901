namespace Ovningar20220901
{
    public class Snake
    {
        public int _width;
        public int _height;
        public int _randomShapes;
        private int[] _playerPos = new int[2];
        private bool _showPlayer;
        private string[] _drawArray;
        public bool shouldPlay;

        public string[] drawArray
        {
            get { return _drawArray; }
            set { _drawArray = value; }
        }
        public int PlayerX
        {
            get { return _playerPos[0]; }
            set { _playerPos[0] = value; }
        }
        public int PlayerY
        {
            get { return _playerPos[1]; }
            set { _playerPos[1] = value; }
        }
        public bool ShowPlayer
        {
            get { return _showPlayer; }
            set { _showPlayer = value; }
        }
        public int RandomShapes
        {
            get { return _randomShapes; }
            set { _randomShapes = value; }
        }


        public string[] DrawBox()
        {
            String[] tempArray = new string[_height];
            var rand = new Random();
            for (var i = 0; i < _height; i++)
            {
                for (var k = 0; k < _width; k++)
                {
                    if (k == _playerPos[0] && i == _playerPos[1] && _showPlayer)
                    {
                        tempArray[i] += "@";
                    }
                    else
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
                if (placeX == _playerPos[0] || placeY == _playerPos[1] || tempArray[placeY][placeX] == '#') continue;
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
            if (_playerPos[0] + x > 0 && _playerPos[0] + x < _width)
            {
                if (_drawArray[_playerPos[1]][_playerPos[0] + x] != '#')
                {
                    _playerPos[0] += x;
                }
            }
            if (_playerPos[1] + y > 0 && _playerPos[1] + y < _height)
            {
                if (_drawArray[_playerPos[1] + y][_playerPos[0]] != '#')
                {
                    _playerPos[1] += y;
                }
            }
        }
    }
}
