public class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public double AverageGrade { get; set; }
    public int Course { get; set; }
    public string MobilePhone { get; set; }

    public Student(string lastName, string firstName, double averageGrade, int course, string mobilePhone)
    {
        LastName = lastName;
        FirstName = firstName;
        AverageGrade = averageGrade;
        Course = course;
        MobilePhone = mobilePhone;
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName}, середній бал: {AverageGrade}, курс: {Course}, телефон: {MobilePhone}";
    }
}
