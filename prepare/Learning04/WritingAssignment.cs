using System;

public class WritingAssignment : Assignment
{
    // Attributes
    private string _title;

    // Constructors
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    // Methods
    public string GetWritingInformation()
    {
        return ($"{_title} by {_studentName}");
    }
}

// NOTED FROM SAMPLE SOLUTION:
// Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
// it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.

// An alternative to changing the Assignment attributes to protected instead of private:
    // Create extra getters in Assignment
    // use this code for the GetWritingInformation() Method
    // public string GetWritingInformation()
    // {
    //     // Notice that we are calling the getter here because _studentName is private in the base class
    //     string studentName = GetStudentName();

    //     return $"{_title} by {studentName}";
    // }