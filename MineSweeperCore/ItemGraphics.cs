using System.Drawing;

namespace MinesweeperCore
{
    public class GraphicsItem
    {

        private int _columns;

        private readonly Graphics _g;

        //the height of item
        private int _grItemHeight;

        //the width of item
        private int _grItemWidth;

        //height of mineMap picture
        private int _height;

        public Image Img;

        private int _rows;

        //width of mineMap picture
        private int _width;

        public GraphicsItem(Image beginImage, int columns, int rows, int grItemWidth, int grItemHeight)
        {
            ResetAttribute(columns, rows, grItemWidth, grItemHeight);
            Img = new Bitmap(_width, _height);
            _g = Graphics.FromImage(Img);
            ResetBeginImage(beginImage);
        }

        //
        public void ResetAttribute(int columns, int rows, int grItemWidth, int grItemHeight)
        {
            _grItemWidth = grItemWidth;
            _grItemHeight = grItemHeight;
            _rows = rows;
            _columns = columns;
            _width = _columns * _grItemWidth;
            _height = _rows * _grItemHeight;
        }

        //make default image
        public void ResetBeginImage(Image beginImageItem)
        {
            for (var x = 0; x < _columns; x++)
            {
                for (var y = 0; y < _rows; y++)
                {
                    DrawItem(beginImageItem, x, y);
                }
            }
        }

        //method to change image of item
        public void DrawItem(Image image, int column, int row)
        {
            _g.DrawImage(image, column * _grItemWidth, row * _grItemHeight, _grItemWidth, _grItemHeight);
        }
    }
}