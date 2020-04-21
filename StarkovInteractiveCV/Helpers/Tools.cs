using System;
using Xamarin.Forms;

namespace StarkovInteractiveCV.Helpers
{
    public static class Tools
    {
        public static Point[] GetStarTopsCoordinates(int topsQuantity, Point centerCoordinates, double radius)
        {
            var points = new Point[topsQuantity];
            for (int i = 0; i < topsQuantity; i++)
            {
                var angle = 2 * Math.PI * i / topsQuantity;
                points[i] = new Point(radius * Math.Sin(angle) + centerCoordinates.X, radius * Math.Cos(angle) + centerCoordinates.Y);
            }

            return points;
        }
    }
}
