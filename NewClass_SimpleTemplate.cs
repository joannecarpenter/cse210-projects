using System;

class NewClass
{
    // Attributes
    public string _attribute1 = "";
    public string _attribute2 = "";

    // Constructors
    public NewClass()
    {
        _attribute1 = "dog";
        _attribute2 = "cat";
    }

    // Methods 
    public void NewClassMethod1()
    {
       Console.WriteLine($"I have a {_attribute1} and a {_attribute2}");

    }

    public void NewClassMethod2()
    {
        
    }
}