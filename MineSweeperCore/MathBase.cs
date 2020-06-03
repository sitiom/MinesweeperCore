using System;
using System.Collections;

namespace MinesweeperCore
{
	/// <summary>
	///     Summary description for MathBase.
	/// </summary>
	public struct StatusMine
    {
        //if item have mine
        public bool IsMine { get; set; } 

        //near mine of item
        public int NearMine { get; set; }

        //the remain near mine of a item when game start
        public int NearMineRemain { get; set; }

        /// <summary>
        ///     0: No Label
        ///     1: Left click, if not have mine it display NearMine
        ///    -1: '?' if Mark (?) is checked
        ///    -2: Flag mine displayed
        /// </summary>
        public int Status { get; set; }
    }

    public struct DrawQueue
    {
        // X
        public int X;

        // Y
        public int Y;

        /// <summary>
        /// the index of property image
        ///  0: nomine0
        ///  1: nomine1
        ///  2: nomine2
        ///  3: nomine3
        ///  4: nomine4
        ///  5: nomine5
        ///  6: nomine6
        ///  7: nomine7
        ///  8: nomine8
        ///  9: nolabel
        /// 10: minelabeled
        /// 11: undefinemine
        /// 12: mineclicked
        /// 13: nominecheckmine
        /// 14: mineuncheck
        /// </summary>
        public int NImg;

        public void Init(int x, int y, int nImg)
        {
            X = x;
            Y = y;
            NImg = nImg;
        }
    }

    public class MathBase
    {
        //array contain the property of items
        private StatusMine[,] _arrayMine;

        private int _columns;

        //the queue to process image
        private DrawQueue _dq;

        //check the game is missed

        //check the game is win
        public bool IsWin { get; private set; }
        //property is display mark or not
        public bool Mark { set; get; }
        //array contain the near item of a item
        private readonly int[,] _near = {{-1, -1}, {-1, 0}, {-1, 1}, {0, 1}, {1, 1}, {1, 0}, {1, -1}, {0, -1}};

        //when start new property is plused one to make new random mine
        private int _remainArea;
        private int _rows;
        private int _totalArea;
        private int _totalMine;

        public bool IsFinished { set; get; }

        public Queue ThisQueue { set; get; }

        public int RemainMine { get; private set; }

        public MathBase(int columns, int rows, int totalMine)
        {
            ThisQueue = new Queue();
            _dq = new DrawQueue();
            InitAttribute(columns, rows, totalMine);
            RestartAttributeGame();
        }

        //the method to init new property of game
        public void InitAttribute(int columns, int rows, int totalMine)
        {
            _columns = columns;
            _rows = rows;
            _totalMine = totalMine;
            _totalArea = _columns * _rows;
            _arrayMine = new StatusMine[_columns, _rows];
        }

        //the method is used when start new game
        public void RestartAttributeGame()
        {
            _remainArea = _totalArea;
            RemainMine = _totalMine;
            IsFinished = false;
            IsWin = false;
            for (var x = 0; x < _columns; x++)
            for (var y = 0; y < _rows; y++)
            {
                _arrayMine[x, y].IsMine = false;
                _arrayMine[x, y].NearMine = 0;
                _arrayMine[x, y].NearMineRemain = 0;
                _arrayMine[x, y].Status = 0;
            }
        }

        #region MethodComponent

        public void LeftDown(int x, int y)
        {
            if (_arrayMine[x, y].Status == 0 || _arrayMine[x, y].Status == -1)
                _dq.Init(x, y, 0);
            ThisQueue.Enqueue(_dq);
        }

        public void BothDown(int x, int y)
        {
            LeftDown(x, y);
            for (var i = 0; i < 8; i++)
                if (x + _near[i, 0] >= 0 && x + _near[i, 0] < _columns && y + _near[i, 1] >= 0 && y + _near[i, 1] < _rows)
                    LeftDown(x + _near[i, 0], y + _near[i, 1]);
        }

        public void RightClick(int x, int y)
        {
            switch (_arrayMine[x, y].Status)
            {
                case 0:
                    _arrayMine[x, y].Status = -2;
                    _dq.Init(x, y, 10);
                    ThisQueue.Enqueue(_dq);
                    for (var i = 0; i < 8; i++)
                        if (x + _near[i, 0] >= 0 && x + _near[i, 0] < _columns && y + _near[i, 1] >= 0 &&
                            y + _near[i, 1] < _rows)
                            _arrayMine[x + _near[i, 0], y + _near[i, 1]].NearMineRemain--;
                    RemainMine--;
                    _remainArea--;
                    break;
                case -1:
                    _arrayMine[x, y].Status = 0;
                    _dq.Init(x, y, 9);
                    ThisQueue.Enqueue(_dq);
                    break;
                case -2:
                    if (Mark)
                    {
                        _arrayMine[x, y].Status = -1;
                        _dq.Init(x, y, 11);
                        ThisQueue.Enqueue(_dq);
                    }
                    else
                    {
                        _arrayMine[x, y].Status = 0;
                        _dq.Init(x, y, 9);
                        ThisQueue.Enqueue(_dq);
                    }

                    for (var i = 0; i < 8; i++)
                        if (x + _near[i, 0] >= 0 && x + _near[i, 0] < _columns && y + _near[i, 1] >= 0 &&
                            y + _near[i, 1] < _rows)
                            _arrayMine[x + _near[i, 0], y + _near[i, 1]].NearMineRemain++;
                    RemainMine++;
                    _remainArea++;
                    break;
            }
        }

        public void LeftClick(int x, int y)
        {
            if (_arrayMine[x, y].Status == 0 || _arrayMine[x, y].Status == -1)
            {
                _arrayMine[x, y].Status = 1;
                if (_arrayMine[x, y].IsMine)
                {
                    IsFinished = true;
                    _dq.Init(x, y, 12);
                    ThisQueue.Enqueue(_dq);
                }
                else
                {
                    _dq.Init(x, y, _arrayMine[x, y].NearMine);
                    ThisQueue.Enqueue(_dq);
                    _remainArea--;
                    if (_remainArea == RemainMine) IsWin = true;
                    if (_arrayMine[x, y].NearMine == 0)
                        for (var i = 0; i < 8; i++)
                            if (x + _near[i, 0] >= 0 && x + _near[i, 0] < _columns && y + _near[i, 1] >= 0 &&
                                y + _near[i, 1] < _rows)
                                if (_arrayMine[x + _near[i, 0], y + _near[i, 1]].Status == 0 ||
                                    _arrayMine[x + _near[i, 0], y + _near[i, 1]].Status == -1)
                                    LeftClick(x + _near[i, 0], y + _near[i, 1]);
                }
            }
        }

        public void BothClick(int x, int y)
        {
            if (_arrayMine[x, y].NearMineRemain == 0 && _arrayMine[x, y].Status == 1)
            {
                for (var i = 0; i < 8; i++)
                    if (x + _near[i, 0] >= 0 && x + _near[i, 0] < _columns && y + _near[i, 1] >= 0 && y + _near[i, 1] < _rows)
                        if (_arrayMine[x + _near[i, 0], y + _near[i, 1]].Status == 0 ||
                            _arrayMine[x + _near[i, 0], y + _near[i, 1]].Status == -1)
                            LeftClick(x + _near[i, 0], y + _near[i, 1]);
            }
            else
            {
                BothOut(x, y);
            }
        }

        public void LeftMove(int x, int y)
        {
            if (x >= 0 && x < _columns && y >= 0 && y < _rows) LeftDown(x, y);
        }

        public void BothMove(int x, int y)
        {
            BothDown(x, y);
        }

        public void LeftOut(int x, int y)
        {
            if ((_arrayMine[x, y].Status == 0 || _arrayMine[x, y].Status == -1) && x >= 0 && x < _columns && y >= 0 &&
                y < _rows)
            {
                _dq.Init(x, y, 9);
                ThisQueue.Enqueue(_dq);
            }
        }

        public void BothOut(int x, int y)
        {
            LeftOut(x, y);
            for (var i = 0; i < 8; i++)
                if (x + _near[i, 0] >= 0 && x + _near[i, 0] < _columns && y + _near[i, 1] >= 0 && y + _near[i, 1] < _rows)
                    LeftOut(x + _near[i, 0], y + _near[i, 1]);
        }

        //the method use when player miss the game
        public void Finished()
        {
            for (var x = 0; x < _columns; x++)
            for (var y = 0; y < _rows; y++)
                switch (_arrayMine[x, y].Status)
                {
                    case 0:
                        if (_arrayMine[x, y].IsMine)
                        {
                            _dq.Init(x, y, 14);
                            ThisQueue.Enqueue(_dq);
                        }

                        break;
                    case -1:
                        if (_arrayMine[x, y].IsMine)
                        {
                            _dq.Init(x, y, 14);
                            ThisQueue.Enqueue(_dq);
                        }

                        break;
                    case -2:
                        if (!_arrayMine[x, y].IsMine)
                        {
                            _dq.Init(x, y, 13);
                            ThisQueue.Enqueue(_dq);
                        }

                        break;
                }
        }

        //the method appear when player win the game
        public void Win()
        {
            RemainMine = 0;
            for (var x = 0; x < _columns; x++)
            for (var y = 0; y < _rows; y++)
                if (_arrayMine[x, y].Status == 0 || _arrayMine[x, y].Status == -1)
                {
                    _arrayMine[x, y].Status = -2;
                    _dq.Init(x, y, 10);
                    ThisQueue.Enqueue(_dq);
                }
        }

        //make the array of mine property 
        public void MakeMineMap(int click)
        {
            MakeRandMine(click);
            for (var i = 0; i < _columns; i++)
            for (var j = 0; j < _rows; j++)
            {
                _arrayMine[i, j].NearMine = CountMine(i, j);
                _arrayMine[i, j].NearMineRemain = _arrayMine[i, j].NearMine;
            }
        }

        //count the near mine
        public int CountMine(int x, int y)
        {
            var c = 0;
            for (var i = 0; i < 8; i++)
                if (x + _near[i, 0] >= 0 && x + _near[i, 0] < _columns && y + _near[i, 1] >= 0 && y + _near[i, 1] < _rows &&
                    _arrayMine[x + _near[i, 0], y + _near[i, 1]].IsMine)
                    c++;
            return c;
        }

        //make rand mine
        public void MakeRandMine(int click)
        {
            int count = 0;
            var randObj = new Random();
            int currentNum = click;
            while (count < _totalMine)
            {
                int i = randObj.Next(0, _totalArea - 1);
                currentNum = currentNum + i;
                currentNum = currentNum % _totalArea;
                if (currentNum != click &&
                    !_arrayMine[currentNum % _columns, (int) Math.Floor((double) currentNum / _columns)].IsMine)
                {
                    _arrayMine[currentNum % _columns, (int) Math.Floor((double) currentNum / _columns)].IsMine = true;
                    count++;
                }
            }
        }

        #endregion
    }
}