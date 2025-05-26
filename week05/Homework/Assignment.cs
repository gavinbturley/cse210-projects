public class Assignment
{
    private string _studentName;
    private string _topic;
    public string GetSummary()
    {
        return $"{_studentName}: {_topic}";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
}

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList()
    {
        return $"{_textbookSection}, {_problems}";
    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
    {
        Assignment assignment = new Assignment(studentName, topic);
        _textbookSection = textbookSection;
        _problems = problems;
    }
}

public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        Assignment assignment = new Assignment(studentName, topic);
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}