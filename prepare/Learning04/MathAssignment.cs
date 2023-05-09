using System;

public class MathAssignment : Assignment
{
    // Attributes
    private string _textbookSection, _problems;

    // Constructors
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Methods
    public string GetHomeworkList()
    {
        return ($"Section {_textbookSection} Problems {_problems}");
    }
}

// NOTED FROM SAMPLE SOLUTION
// Line 9 --> Notice the syntax here that the MathAssignment constructor has 4 parameters and then
// it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
