using System;
using System.Drawing;

class PhotoIntegration
{
    static void Main(string[] args)
    {
        string imagePath = "img/photo1.jpg";
        //string inputText = "bibendum neque vitae placerat. Curabitur mi justo, suscipit ac lectus vitae, feugiat ullamcorper nunc. Sed congue erat sed metus dignissim, pharetra eleifend dolor consequat. Proin tristique laoreet dapibus. Donec sed orci at lectus faucibus luctus. Nulla eu libero mauris. Sed porta sem at libero vestibulum dignissim. Praesent ante velit, convallis fermentum risus id, ultrices tincidunt sem. Suspendisse nisl nibh, aliquam porta aliquam euismod, sollicitudin vitae erat. Donec tincidunt lectus eu fermentum malesuada. Nunc non neque in lacus fringilla semper vel tempor tellus. Integer a elit aliquet, pellentesque neque maximus, iaculis quam. Etiam porta lectus eu tempus scelerisque. Cras in pellentesque dui. Sed non ex auctor, sodales velit in, viverra risus. Pellentesque vitae rutrum risus, vitae mattis ante.";
        string imagePathEncoded = "img/photo1-updated.jpg";
        string inputText = "a";

        EncodeImage(imagePath, inputText);
        DecodeImage(imagePath, imagePathEncoded);
    }

    static void EncodeImage(string imagePath, string inputText)
    {
        Bitmap bitmap = new Bitmap(imagePath);

        for (int y = 0; y < bitmap.Height; y++)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                Color pixelColor = bitmap.GetPixel(x, y);
                int asciiValue = (int)inputText[(x + y * bitmap.Width) % inputText.Length];
                //Console.WriteLine(asciiValue);
                int newPixelValue = (pixelColor.R + asciiValue) % 255;
                Color newColor = Color.FromArgb(newPixelValue, newPixelValue, newPixelValue);
                bitmap.SetPixel(x, y, newColor);
            }
        }

        bitmap.Save("img/photo1-updated.jpg");
        Console.WriteLine("L'image a été modifiée avec succès.");
    }

    static void DecodeImage(string imagePath, string imagePathEncoded)
    {
        Bitmap bitmap = new Bitmap(imagePath);
        Bitmap bitmapEncoded = new Bitmap(imagePathEncoded);

        string text = "";

        for (int y = 0; y < bitmap.Height; y++)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                Color pixelColor = bitmap.GetPixel(x, y);
                Color pixelColorEncoded = bitmapEncoded.GetPixel(x, y);
                //Console.WriteLine(pixelColorEncoded.R - pixelColor.R);
            }
        }

        Console.WriteLine("Texte décodé : " + text);
    }
}

