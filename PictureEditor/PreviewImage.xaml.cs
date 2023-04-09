using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PictureEditor;

public partial class PreviewImage : Page
{
    private string filePath;
    public PreviewImage(string filePath)
    {
        InitializeComponent();
        this.filePath = filePath;
        DropImage();
    }

    private void DropImage()
    {
        BitmapImage bitmap = new BitmapImage();
        bitmap.BeginInit();
        bitmap.UriSource = new Uri(filePath, UriKind.Absolute);
        bitmap.EndInit();
        windowPreviewImage.Source = bitmap;
    }
}