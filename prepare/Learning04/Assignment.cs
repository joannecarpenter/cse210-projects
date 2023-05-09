using System;

public class Assignment
{
    // Attributes
    protected string _studentName, _topic;

    // Constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Methods
    public string GetSummary()
    {
        return ($"{_studentName} - {_topic}");
    }
}

// NOTED FROM SAMPLE SOLUTION
// Instead of changing line 6 from private to protected,
// we could create two extra getters in the methods as follows
//  public string GetStudentName()
// {
//     return _studentName;
// }

// public string GetTopic()
// {
//     return _topic;
// }

// public string GetSummary()
// {
//     return _studentName + " - " + _topic;
// }