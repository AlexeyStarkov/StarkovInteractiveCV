using System;
using Xamarin.Forms;

namespace StarkovInteractiveCV.Helpers
{
    public static class Tools
    {
        public static Point[] GetStarTopsCoordinates(int topsQuantity, Point centerCoordinates, double radius, int accuracyDigits)
        {
            var points = new Point[topsQuantity];
            for (int i = 0; i < topsQuantity; i++)
            {
                var angle = 2 * Math.PI * i / topsQuantity - 1.5708;
                points[i] = new Point(Math.Round(radius * Math.Cos(angle) + centerCoordinates.X, accuracyDigits), Math.Round(radius * Math.Sin(angle) + centerCoordinates.Y, accuracyDigits));
            }

            return points;
        }
    }
}
