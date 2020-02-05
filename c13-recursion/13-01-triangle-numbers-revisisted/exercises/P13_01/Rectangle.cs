namespace P13_01
{
    public class Rectangle
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int GetArea()
        {
            if (_width == 1 ) { return _height; }
            else if (_width <= 0 || _height <= 0) { return 0; }
            else 
            {
                var smallerRectangle = new Rectangle(_width - 1, _height);
                var area = smallerRectangle.GetArea() + _height;
                return area;
            }
        }
    }
}