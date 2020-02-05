namespace P13_02
{
    public class Square
    {
        private int _width;

        public Square(int width)
        {
            _width = width;
        }

        public int GetArea()
        {
            if (_width == 1) { return 1; }
            else if (_width <= 0) { return 0; }
            else 
            {
                var smallerSquare = new Square(_width - 1);
                var area = smallerSquare.GetArea() + (2 * (_width - 1) + 1);
                return area;
            }
        }
    }
}