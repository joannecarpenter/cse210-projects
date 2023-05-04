using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        string frac1 = fraction1.GetFractionString();
        Console.WriteLine(frac1);
        string dec = (fraction1.GetDecimalValue()).ToString();
        Console.WriteLine(dec);

        Fraction fraction2 = new Fraction(5);
        string frac2 = fraction2.GetFractionString();
        Console.WriteLine(frac2);
        string dec2 = (fraction2.GetDecimalValue()).ToString();
        Console.WriteLine(dec2);

        Fraction fraction3 = new Fraction(3, 4);
        string frac3 = fraction3.GetFractionString();
        Console.WriteLine(frac3);
        string dec3 = (fraction3.GetDecimalValue()).ToString();
        Console.WriteLine(dec3);

        Fraction fraction4 = new Fraction(1, 3);
        string frac4 = fraction4.GetFractionString();
        Console.WriteLine(frac4);
        string dec4 = (fraction4.GetDecimalValue()).ToString();
        Console.WriteLine(dec4);
    }
}