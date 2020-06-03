using System;
using System.Windows.Forms;

namespace MinesweeperCore
{
    public enum EventList
    {
        LeftDown,
        BothDown,
        RightClick,
        LeftClick,
        BothClick,
        LeftMove,
        BothMove,
        LeftOut,
        BothOut
    }

    public class ImgEventArgs : EventArgs
    {
        public EventList Event;
        public int X;
        public int Y;

        public ImgEventArgs()
        {
            X = 0;
            Y = 0;
            Event = 0;
        }

        public void Active(int x, int y, EventList @event)
        {
            X = x;
            Y = y;
            Event = @event;
        }
    }

    public class ImgMouseEventHandler
    {
        public delegate void ImgEventHandler(object sender, ImgEventArgs iea);

        private bool _clicked;
        private int _itemHeight;
        private int _itemWeight;
        private bool _leftDown;
        private bool _otherDown;
        private bool _out;
        private bool _rightDown;
        private readonly int _columns;
        private readonly ImgEventArgs _ie;
        private int _mx;
        private int _my;

        private readonly int _rows;

        public ImgMouseEventHandler(int columns, int rows, int w, int h)
        {
            ResetAttribute();
            _columns = columns;
            _rows = rows;
            InitSizeItem(w, h);
            _ie = new ImgEventArgs();
        }

        public event ImgEventHandler Event;

        public void ResetAttribute()
        {
            _mx = 0;
            _my = 0;
            _leftDown = false;
            _rightDown = false;
            _clicked = false;
            _otherDown = false;
            _out = false;
        }

        public void InitSizeItem(int w, int h)
        {
            _itemWeight = w;
            _itemHeight = h;
        }

        private void ActiveEvent(object sender, EventList @event)
        {
            if (!_out)
            {
                _ie.Active(_mx, _my, @event);
                Event(sender, _ie);
            }
        }

        public void MouseDown(object sender, MouseEventArgs me)
        {
            switch (me.Button)
            {
                case MouseButtons.Left:
                    _leftDown = true;
                    if (_otherDown)
                    {
                        _clicked = true;
                        ActiveEvent(sender, EventList.BothDown);
                    }
                    else
                    {
                        if (_rightDown)
                        {
                            _clicked = true;
                            ActiveEvent(sender, EventList.BothDown);
                        }
                        else
                        {
                            ActiveEvent(sender, EventList.LeftDown);
                        }
                    }

                    break;
                case MouseButtons.Right:
                    _rightDown = true;
                    if (_otherDown)
                    {
                        _clicked = true;
                        ActiveEvent(sender, EventList.BothDown);
                    }
                    else
                    {
                        if (_leftDown)
                        {
                            _clicked = true;
                            ActiveEvent(sender, EventList.BothDown);
                        }
                        else
                        {
                            if (!_clicked) ActiveEvent(sender, EventList.RightClick);
                        }
                    }

                    break;
                default:
                    _otherDown = true;
                    _clicked = true;
                    ActiveEvent(sender, EventList.BothDown);
                    break;
            }
        }

        public void MouseUp(object sender, MouseEventArgs me)
        {
            switch (me.Button)
            {
                case MouseButtons.Left:

                    _leftDown = false;
                    if (_otherDown)
                    {
                        ActiveEvent(sender, EventList.BothClick);
                    }
                    else
                    {
                        if (_rightDown)
                        {
                            ActiveEvent(sender, EventList.BothClick);
                        }
                        else
                        {
                            if (!_clicked)
                            {
                                ActiveEvent(sender, EventList.LeftClick);
                            }
                            else
                            {
                                _clicked = false;
                                ActiveEvent(sender, EventList.LeftOut);
                            }
                        }
                    }

                    break;
                case MouseButtons.Right:
                    _rightDown = false;
                    if (_otherDown)
                    {
                        ActiveEvent(sender, EventList.BothClick);
                    }
                    else
                    {
                        if (_leftDown)
                            ActiveEvent(sender, EventList.BothClick);
                        else
                            _clicked = false;
                    }

                    break;
                default:
                    _otherDown = false;
                    if (!_leftDown && !_rightDown)
                    {
                        _clicked = false;
                        ActiveEvent(sender, EventList.BothClick);
                    }

                    if (_leftDown && _rightDown) ActiveEvent(sender, EventList.BothClick);
                    break;
            }
        }

        public void MouseMove(object sender, MouseEventArgs me)
        {
            if (me.X >= (_mx + 1) * _itemWeight || me.X < _mx * _itemWeight || me.Y >= (_my + 1) * _itemHeight ||
                me.Y < _my * _itemHeight)
            {
                if (_leftDown && _rightDown || _otherDown) ActiveEvent(sender, EventList.BothOut);
                if (_leftDown && !_otherDown && !_clicked) ActiveEvent(sender, EventList.LeftOut);

                int x = (int) Math.Floor((double) me.X / _itemWeight);
                int y = (int) Math.Floor((double) me.Y / _itemHeight);
                if (x >= 0 && x < _columns && y >= 0 && y < _rows && (x != _mx || y != _my))
                {
                    _out = false;
                    _mx = x;
                    _my = y;
                    if (_leftDown && _rightDown || _otherDown) ActiveEvent(sender, EventList.BothMove);
                    if (_leftDown && !_otherDown && !_clicked) ActiveEvent(sender, EventList.LeftMove);
                }
                else
                {
                    _out = true;
                }
            }
        }
    }
}