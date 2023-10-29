using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShellSort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const int ArraySize = 123; // Размер сортируемого массива
        private const int Delay = 10; // Задержка анимации (в миллисекундах)

        private int comprassionsCount = 0;
        private List<Rectangle> rectangles;
        private List<int> data;
        private int gap;
        private int current;
        private bool isSorting;

        public MainWindow()
        {
            InitializeComponent();
            rectangles = new List<Rectangle>();
            data = new List<int>();
            gap = 0;
            current = 0;
            isSorting = false;
        }

        private void GenerateData(int count)
        {
            randomButton.IsEnabled = false;
            resetButton.IsEnabled = false;
            data.Clear();
            rectangles.Clear();
            canvas.Children.Clear();
            var random = new Random();
            
            for (var i = 0; i < count; i++)
            {
                var value = random.Next(1, 398);
                data.Add(value);
                
                rectangles.Add(new Rectangle
                {
                    Width = 5,
                    Height = data[i], // Высота прямоугольника соответствует элементу массива
                    Fill = Brushes.White
                });
                Canvas.SetTop(rectangles[i], 398 - rectangles[i].Height); // Расположение прямоугольника по оси Y
                Canvas.SetLeft(rectangles[i], 2 + (i * 6)); // Расположение прямоугольника по оси X

                canvas.Children.Add(rectangles[i]); // Добавление прямоугольника на Canvas
            }
            fillTb();
            gap = data.Count / 2;
            current = gap;

            randomButton.IsEnabled = true;
            resetButton.IsEnabled = true;
        }

        private void fillTb()
        {
            TbArray.Text = "";
            for (var value = 0; value < data.Count; value++)
            {
                if(value != data.Count - 1)
                    TbArray.Text += $"[{data[value]}], ";
                else
                    TbArray.Text += $"[{data[value]}].";
            }
        }
        
        private async void SortButton_Click(object sender, RoutedEventArgs e)
        {
            if (isSorting)
            {
                return;
            }

            isSorting = true;
            sortButton.IsEnabled = false;
            randomButton.IsEnabled = false;
            resetButton.IsEnabled = false;
            await StartSorting();
            isSorting = false;
            sortButton.IsEnabled = true;
            randomButton.IsEnabled = true;
            resetButton.IsEnabled = true;
            foreach (var t in rectangles)
            {
                t.Fill = Brushes.Green;
                await Task.Delay(Delay);
            }
            fillTb();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (isSorting)
            {
                return;
            }

            comprassionsCount = 0;
            lblSwapCount.Content = 0;
            GenerateData(ArraySize);
        }

        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
            if (isSorting)
            {
                return;
            }

            GenerateData(ArraySize);
        }

        private async Task StartSorting()
        {
            while (gap > 0)
            {
                for (var i = current; i < data.Count; i++)
                {
                    var temp = data[i];
                    var j = i;

                    while (j >= current && data[j - current] > temp)
                    {
                        data[j] = data[j - current];
                        rectangles[j].Fill = Brushes.Red;
                        j -= gap;
                        comprassionsCount++;
                        lblSwapCount.Content = comprassionsCount;
                        await Task.Delay(Delay); // Задержка для анимации
                        RedrawRectangles();
                    }

                    foreach (var rec in rectangles)
                    {
                        rec.Fill = Brushes.White;
                    }
                    data[j] = temp;
                }

                gap /= 2;
                current = gap;
                await Task.Delay(Delay);  // Задержка для анимации
                RedrawRectangles();
            }
        }

        private void RedrawRectangles()
        {
            for (var i = 0; i < rectangles.Count; i++)
            {
                rectangles[i].Height = data[i];
                Canvas.SetTop(rectangles[i], 398 - rectangles[i].Height); // Расположение прямоугольника по оси Y
            }
        }
        
        private void canvas_OnLoaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
