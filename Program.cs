using System;

class Program
{
    static void Main()
    {
        Action showCurrentTime = () => Console.WriteLine("Time Now: " + DateTime.Now.ToShortTimeString());
        Action showCurrentDate = () => Console.WriteLine("Date Now: " + DateTime.Now.ToShortDateString());
        Action showCurrentDay = () => Console.WriteLine("Day of the week Now: " + DateTime.Now.DayOfWeek);

        showCurrentTime();
        showCurrentDate();
        showCurrentDay();



        Func<double, double, double> TriangleArea = (b, h) => 0.5 * b * h;
        Func<double, double, double> RectangleArea = (w, h) => w * h;

        Console.WriteLine("Area triangle (2, 8) : " + TriangleArea(2,8));
        Console.WriteLine("Area rectangle (10, 5): " + RectangleArea(10, 5));




        Predicate<int> isPositive = x => x > 0;

        Console.WriteLine("7 positiv? " + isPositive(7));
        Console.WriteLine("-12 positiv " + isPositive(-12));
        Console.WriteLine("56 positiv? " + isPositive(56));
        Console.WriteLine("-99 positiv " + isPositive(-99));
    }
}
