using System;
using System.IO;
using System.Printing;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using PictureEditor.ImageProcessing;

namespace PictureEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string filePath = "";
        
        /*private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            for (int x = 0; x <= 50; x++)
            {
                for (int y = 0; y <= 50; y++)
                {
                    Rectangle rec = new Rectangle();
                    Canvas.SetTop(rec, y);
                    Canvas.SetLeft(rec, x);
                    rec.Width = 1;
                    rec.Height = 1;
                    rec.Fill = new SolidColorBrush(Colors.Red);
                    rec.StrokeThickness=2;
                    Canvas.Children.Add(rec);
                }
            }
        }*/

        private void DownloadImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.bmp)|*.bmp";
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
                Picture.NavigationService.Navigate(new PreviewImage(filePath));
            }
        }

        private void ShowOriginalImage(object sender, RoutedEventArgs e)
        {
            OriginalImage originalImage = new OriginalImage();
            originalImage.ReadImage(filePath);
            originalImage.CreatePixels();
            Picture.NavigationService.Navigate(new ShowOriginalImage(originalImage, filePath));
        }
    }
}