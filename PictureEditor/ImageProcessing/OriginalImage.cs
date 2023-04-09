using System.IO;
namespace PictureEditor.ImageProcessing;

// 12.Логарифмизация шкалы яркости и степенное преобразование со
// смещенным нулем для n < 1 нечетной степени.

public class OriginalImage
{
    private byte[] byteImage;

    private Pixel[] pixels;
    public void ReadImage(string filePath)
    {
        byteImage = File.ReadAllBytes(filePath);
    }

    public void CreatePixels()
    {
        int countPixels = 1000;
        pixels = new Pixel[countPixels * countPixels];
        for (int i = 54; i <= countPixels * countPixels * 3 + 51; i = i + 3)
        {
            pixels[(i - 54) / 3] = new Pixel(byteImage[i], byteImage[i + 1], byteImage[i + 2]);
        }
    }

    public Pixel[] getPixels()
    {
        return pixels;
    }
}