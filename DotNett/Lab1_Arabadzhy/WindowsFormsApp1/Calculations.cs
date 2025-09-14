using System;

namespace Lab1_WinForms
{
    public class Calculations
    {
        public double CalculateF1(double x)
        {
            return Math.Abs(Math.Sqrt((2 * x + 5)) / (Math.Pow(x, 3) + 2));
        }

        public double CalculateF2(double x)
        {
            return (Math.Sqrt(Math.Sin(Math.Pow(x, 2) + 3) + 4)) / (Math.Pow(x, 2) + 2);
        }

        public double CalculateF3(double x)
        {
            return Math.Pow(Math.Sin(x + 2), 3) / Math.Log(Math.Pow(x, 2) + 3 * x + 1);
        }
    }
}