using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using PictureEditor.ImageProcessing;

namespace PictureEditor;

public partial class ShowOriginalImage : Page
{
    private string filePath;
    private Pixel[] pixels;
    public ShowOriginalImage(OriginalImage originalImage, string filePath)
    {
        InitializeComponent();
        pixels = originalImage.getPixels();
        this.filePath = filePath;
        DropImage();
    }

    private void DropImage()
    {
        int countPixels = 1000;
        for (int j = pixels.Length - 1; j >= 0; j = j - countPixels)
        { 
            StackPanel line = new StackPanel
            {
                Opacity = 1,
                Orientation = Orientation.Horizontal,
                Background = new SolidColorBrush(Colors.Transparent)
            };
            for (int i = countPixels - 1; i >= 0; i--)
            {
                Border pixel = new Border()
                {
                    Width = 0.9049,
                    Height = 0.9049,
                    Opacity = 1,
                    ToolTip = "Это пиксель X = " + (j-i) + " Y = " + j/500 + '\n' + "Цвета:" 
                              + '\n' + "Red -> " + pixels[j-i].getPixelR()
                              + '\n' + "Green -> " + pixels[j-i].getPixelG()
                              + '\n' + "Blue -> " + pixels[j-i].getPixelB() 
                              + '\n' + "Яркость -> " + pixels[j-i].GetBrightness(),
                    Background = new SolidColorBrush(Color.FromRgb(pixels[j-i].getPixelR(), pixels[j-i].getPixelG(), pixels[j-i].getPixelB()))
                };
                line.Children.Add(pixel);
            }
            PixelImage.Children.Add(line);
        }
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        double dbl = double.Parse(textBox.Text);
        foreach (StackPanel stackPanel in PixelImage.Children)
        {
            foreach (Border border in stackPanel.Children)
            {
                border.Width = dbl;
                border.Height = dbl;
            }
        }
        //PixelImage.Height = dbl * 500;
        //PixelImage.Width = dbl * 500;
    }
}