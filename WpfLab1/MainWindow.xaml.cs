using System; // Нужно для класса Random
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfLab1
{
    public partial class MainWindow : Window
    {
        // Создаем генератор случайных чисел один раз на уровне класса
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        // ОБРАБОТЧИК НАЖАТИЯ КНОПКИ
        private void BtnRandomTriangle_Click(object sender, RoutedEventArgs e)
        {
            ClearScene(); // Сначала очищаем холст от старых рисунков

            // Генерируем 3 случайные точки в пределах размеров холста
            Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));

            // Создаем треугольник
            Triangle tr = new Triangle(p1, p2, p3);

            // Рисуем его
            DrawTriangle(tr);
        }

        public void DrawLine(Point2D p1, Point2D p2)
        {
            Line line = new Line();
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 3;

            line.X1 = p1.X;
            line.Y1 = p1.Y;
            line.X2 = p2.X;
            line.Y2 = p2.Y;

            Scene.Children.Add(line);
        }

        public void DrawTriangle(Triangle tr)
        {
            DrawLine(tr.P1, tr.P2);
            DrawLine(tr.P2, tr.P3);
            DrawLine(tr.P3, tr.P1);
        }

        public void ClearScene()
        {
            Scene.Children.Clear();
        }
    }
}