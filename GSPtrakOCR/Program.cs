using GSPtrakOCR;
using System.Drawing;


    string processName = "Chrome";
    Console.WriteLine("Window Handle: " + Screenshot.WinGetHandle(processName));
    Bitmap bitmap = Screenshot.PrintWindow(Screenshot.WinGetHandle(processName));
    bitmap.Save("image.png", System.Drawing.Imaging.ImageFormat.Png);



    Screenshot2 screenshot2 = new Screenshot2();
    Bitmap bitmap2 = screenshot2.CaptureApplication("Chrome");
    bitmap2.Save("image2.png", System.Drawing.Imaging.ImageFormat.Png);




