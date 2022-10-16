using Microsoft.Maui.Graphics;
using System;

namespace DigitalClock
{
    public class GraphicsDrawable : IDrawable
    {
        public int offset = 55;

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {

            canvas.StrokeColor = Colors.Red; // tochka vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * 2, 25, 20 + offset * 2, 35);

            canvas.StrokeColor = Colors.Red; // tochka niz
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * 2, 45, 20 + offset * 2, 55);

            canvas.StrokeColor = Colors.Red; // tochka vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * 4 + 20, 25, 20 + offset * 4 + 20, 35);

            canvas.StrokeColor = Colors.Red; // tochka niz
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * 4 + 20, 45, 20 + offset * 4 + 20, 55);

            var time = DateTime.Now;

            int tens = time.Second / 10;
            int units = time.Second % 10;

            DrawTime(canvas, 4, tens);
            DrawTime(canvas, 5, units);

            tens = time.Minute / 10;
            units = time.Minute % 10;

            DrawTime(canvas, 2, tens);
            DrawTime(canvas, 3, units);

            tens = time.Hour / 10;
            units = time.Hour % 10;

            DrawTime(canvas, 0, tens);
            DrawTime(canvas, 1, units);
        }

        public void DrawTime(ICanvas canvas, int n, int time)
        {
            switch (time)
            {
                case 0:
                    DrawZero(canvas, n);
                    break;
                case 1:
                    DrawOne(canvas, n);
                    break;
                case 2:
                    DrawTwo(canvas, n);
                    break;
                case 3:
                    DrawThree(canvas, n);
                    break;
                case 4:
                    DrawFour(canvas, n);
                    break;
                case 5:
                    DrawFive(canvas, n);
                    break;
                case 6:
                    DrawSix(canvas, n);
                    break;
                case 7:
                    DrawSeven(canvas, n);
                    break;
                case 8:
                    DrawEight(canvas, n);
                    break;
                case 9:
                    DrawNine(canvas, n);
                    break;
            }
        }

        public void DrawZero(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 72, 50 + offset * n + pointOffset, 72);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 40, 15 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 5, 15 + offset * n + pointOffset, 35);

        }

        public void DrawOne(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);
        }

        public void DrawTwo(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 72, 50 + offset * n + pointOffset, 72);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 40, 15 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 37, 50 + offset * n + pointOffset, 37);
        }

        public void DrawThree(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 72, 50 + offset * n + pointOffset, 72);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 37, 50 + offset * n + pointOffset, 37);
        }

        public void DrawFour(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 5, 15 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 37, 50 + offset * n + pointOffset, 37);
        }

        public void DrawFive(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 72, 50 + offset * n + pointOffset, 72);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 5, 15 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 37, 50 + offset * n + pointOffset, 37);
        }

        public void DrawSix(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 72, 50 + offset * n + pointOffset, 72);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 40, 15 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 5, 15 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 37, 50 + offset * n + pointOffset, 37);
        }

        public void DrawSeven(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);
        }

        public void DrawEight(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 72, 50 + offset * n + pointOffset, 72);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 40, 15 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 5, 15 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 37, 50 + offset * n + pointOffset, 37);
        }

        public void DrawNine(ICanvas canvas, int n)
        {
            int pointOffset = 0;
            if (n > 1)
            {
                pointOffset = 20;
            }
            if (n > 3)
            {
                pointOffset = 40;
            }

            canvas.StrokeColor = Colors.Red; //vverh
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 0, 50 + offset * n + pointOffset, 0);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 5, 55 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; //sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(55 + offset * n + pointOffset, 40, 55 + offset * n + pointOffset, 70);

            canvas.StrokeColor = Colors.Red; //sled po chas (niz)
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 72, 50 + offset * n + pointOffset, 72);

            canvas.StrokeColor = Colors.Red; // sled po chas
            canvas.StrokeSize = 5;
            canvas.DrawLine(15 + offset * n + pointOffset, 5, 15 + offset * n + pointOffset, 35);

            canvas.StrokeColor = Colors.Red; // center
            canvas.StrokeSize = 5;
            canvas.DrawLine(20 + offset * n + pointOffset, 37, 50 + offset * n + pointOffset, 37);
        }
    }
}