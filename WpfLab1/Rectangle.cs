namespace WpfLab1
{
    public class MyRectangle
    {
        public Point2D TopLeft { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public MyRectangle(Point2D topLeft, int width, int height)
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        // Методы для перемещения 
        public void AddX(int x) => TopLeft.AddX(x);
        public void AddY(int y) => TopLeft.AddY(y);
    }
}