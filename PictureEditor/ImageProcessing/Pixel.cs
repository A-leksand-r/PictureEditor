using System;

namespace PictureEditor.ImageProcessing;

public class Pixel
{
    private byte pixelR;
    
    private byte pixelG;
    
    private byte pixelB;
    
    private double brightness;

    public Pixel(byte pixelB, byte pixelG, byte pixelR)
    {
        this.pixelB = pixelB;
        this.pixelG = pixelG;
        this.pixelR = pixelR;
        brightness = 0.2125 * pixelR + 0.7154 * pixelG + 0.0721 * pixelB;
    }
    public double GetBrightness()
    {
        return brightness;
    }
    public byte getPixelR()
    {
        return pixelR;
    }
    public byte getPixelG()
    {
        return pixelG;
    }
    public byte getPixelB()
    {
        return pixelB;
    }
}