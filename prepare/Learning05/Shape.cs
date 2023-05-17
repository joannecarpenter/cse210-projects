using System;

public abstract class Shape
{
    // Attributes
   protected string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }
    // Methods
    public string GetColor()
    {   
        return _color;
    }

    public void SetColor()
    {
       // Sample solution says to include the following code, but it works so far without it
       // _color = color;
       // also add "string color" to the parameters for this method
    }

    public virtual double GetArea()
    {
        return -1;
    }
    //------------------FROM THE SAMPLE SOLUTION------------------------------
    // Because it does not make sense to define a default body for this method in the
    // base class, rather than make a "virtual" function here like this:
    //
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    //
    // We can instead declare the function as an "abstract" function. That means
    // that it is an empty virtual function that must be implemented or "filled in" by
    // any class that inherits from Shape. Then, any class that has an abstract method
    // must also be declared to be abstract.
    //public abstract double GetArea();
}