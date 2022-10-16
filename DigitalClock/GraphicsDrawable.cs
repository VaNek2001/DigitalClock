using System;
namespace DigitalClock
{
    public class GraphicsDrawable: IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 10;
            canvas.DrawLine(20, 0, 50, 0);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55, 5, 55, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55, 40, 55, 70);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20, 72, 50, 72);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15, 40, 15, 70);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15, 5, 15, 35);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20, 37, 50, 37);

            canvas.StrokeColor = Colors.Red; // tochka vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(70, 25, 70, 35);

            canvas.StrokeColor = Colors.Red; // tochka niz
            canvas.StrokeSize = 5;
            canvas.DrawLine(70, 45, 70, 55);
        }
    }
}

