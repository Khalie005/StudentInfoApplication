using System;

namespace StudentInfoApplication
{
    public class Student
    {
        public string StudentID { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Student(string studentID, string firstName, string lastName)
        {
            StudentID = studentID ?? throw new ArgumentNullException(nameof(studentID));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
    }
}
