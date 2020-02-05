namespace TriangleAreaCalculator
{
    /// <summary>
    /// A triangular shape composed of stacked unit squares like this:
    /// []
    /// [][]
    /// [][][]
    /// . . .
    /// </summary>
    public class Triangle 
    {
        private int _width;

        /// <summary>
        /// Constructs a triangular shape.
        /// </summary>
        /// <param name="width">the width (and height) of the triangle.</param>
        public Triangle(int width)
        {
            _width = width;
        }

        /// <summary>
        /// Computes the area of the triangle.
        /// </summary>
        /// <returns>The area.</returns>
        public int GetArea()
        {
            if (_width <= 0) { return 0; }
            else if (_width == 1) { return 1; }
            else 
            {
                var smallerTriangle = new Triangle(_width - 1);
                var area = smallerTriangle.GetArea() + _width;
                return area;
            }
        }
    }
}