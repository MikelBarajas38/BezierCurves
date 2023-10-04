// See https://aka.ms/new-console-template for more information
using BezierCurves;

Console.WriteLine("Hello, World!");

Point CalculateBezierPoint(double t, Point p0, Point p1, Point p2, Point p3)
{
    double u = 1 - t;
    double tt = t * t;
    double uu = u * u;
    double uuu = uu * u;
    double ttt = tt * t;

    double x = (int)(p0.x * uuu + 3 * p1.x * uu * t + 3 * p2.x * u * tt + p3.x * ttt);
    double y = (int)(p0.y * uuu + 3 * p1.y * uu * t + 3 * p2.y * u * tt + p3.y * ttt);
    double z = (int)(p0.z * uuu + 3 * p1.z * uu * t + 3 * p2.z * u * tt + p3.z * ttt);

    return new Point(x, y, z);
}
