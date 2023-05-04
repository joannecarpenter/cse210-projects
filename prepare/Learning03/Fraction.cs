using System;

public class Fraction
{
    // Attributes
        // Setting attributes in a _attributeName format allows you to see the private attributes
        // quickly amongst all of the other variables in your code
    private int _top;
    private int _bottom;

    // Constructor(s)
    public Fraction()
    {
        // Set the default values for the numerator and denominator
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Methods
    public int GetTop()   //<---I think this is supposed to be a void
    {
        //takes setter retun and sets it to the value within the private 
        // function without sharing the private variable name
        // Request user input and then convert that string to an int by parsing
        Console.Write("Please enter a numerator: ");
        int top = int.Parse(Console.ReadLine());
        _top = top;
        return _top;
    }

    // public int SetTop(int top)
    // // Setter takes user's parameter without sharing private variables
    // {
    //     _top = top;
    //     return _top;
    // }

    // public int GetBottom()  //<---I think this is supposed to be a void
    // {
    //     // Request user input and then convert that string to an int by parsing
    //     Console.Write("Please enter a denominator: ");
    //     int bottom = int.Parse(Console.ReadLine());
    //     _bottom = bottom;
    //     return _bottom;
    // }

    // public int SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    //     return _bottom;
    // }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // It is just a temporary, local variable that will be recomputed each time this is called.
        string fractionString = ($"{_top}/{_bottom}");
        return fractionString;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    } 
}