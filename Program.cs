using System;
using SplashKitSDK;

namespace WorkingWithObjects
{
    public class Program
    {
        public static void Main()
        {
            Window shapesWindow;

            shapesWindow = new Window("House Drawing", 800, 600);
            shapesWindow.Clear(Color.White);
            shapesWindow.FillEllipse(Color.BrightGreen, 0, 400, 800, 400);
            shapesWindow.FillRectangle(Color.Gray, 300, 300, 200, 200);
            shapesWindow.FillTriangle(Color.Red, 250, 300, 400, 150, 550, 300);
            shapesWindow.MoveTo(2,3);

            shapesWindow.Refresh();

            Window shapes = new Window("Shapes", 400, 400);
            shapes.Clear(Color.LightGoldenrodYellow);
            
            shapes.FillTriangle(Color.SkyBlue, 200, 50, 100, 150, 300, 150);
            shapes.FillCircle(Color.PeachPuff, 200, 225, 75);
            shapes.FillEllipse(Color.MediumOrchid, 100, 300, 200, 100);
            shapes.FillCircle(Color.Black, 162.5, 187.5, 9.375);
            shapes.FillCircle(Color.Black, 237.5, 187.5, 9.375);
            shapes.FillRectangle(Color.RosyBrown, 198, 187.5, 9.375, 35);
            shapes.DrawLine(Color.OrangeRed, 162, 240, 246.875, 240);
            
            shapes.Refresh();
            SplashKit.Delay(100000);
            
        }
    }
}
