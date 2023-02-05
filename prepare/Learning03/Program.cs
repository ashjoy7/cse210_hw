using System;

namespace FractionApp
{
    class Fraction
    {
        private int top;
        private int bottom;

        public Fraction()
        {
            this.top = 1;
            this.bottom = 1;
        }

        public Fraction(int top)
        {
            this.top = top;
            this.bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            this.top = top;
            this.bottom = bottom;
        }

        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        public int Bottom
        {
            get { return bottom; }
            set { bottom = value; }
        }

        public string GetFractionString()
        {
            return top + "/" + bottom;
        }

        public double GetDecimalValue()
        {
            return (double)top / bottom;
        }
    }
}

namespace FractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction();
            Fraction frac2 = new Fraction(6);
            Fraction frac3 = new Fraction(6, 7);

            Console.WriteLine("Fraction 1: " + frac1.GetFractionString());
            Console.WriteLine("Fraction 2: " + frac2.GetFractionString());
            Console.WriteLine("Fraction 3: " + frac3.GetFractionString());

            Console.WriteLine("Fraction 1 Decimal Value: " + frac1.GetDecimalValue());
            Console.WriteLine("Fraction 2 Decimal Value: " + frac2.GetDecimalValue());
            Console.WriteLine("Fraction 3 Decimal Value: " + frac3.GetDecimalValue());

            Console.ReadLine();
        }
    }
}