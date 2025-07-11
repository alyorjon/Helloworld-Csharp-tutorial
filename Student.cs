using System;
namespace HELLOWORLD
{
  public class Student
{
    private int studentId;
    private string firstName;
    private string lastName;
    private DateTime birthDate;
    private List<int> grades;
    private string email;
    
    // Auto-implemented properties
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    
    // Constructor
    public Student(int id, string firstName, string lastName, DateTime birthDate)
    {
        this.studentId = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
        this.grades = new List<int>();
        this.email = GenerateEmail();
    }
    
    // Properties with validation
    public int StudentId 
    { 
        get { return studentId; } 
    }
    
    public string FirstName
    {
        get { return firstName; }
        set 
        { 
            if (!string.IsNullOrWhiteSpace(value))
            {
                firstName = value;
                email = GenerateEmail(); // Email yangilanadi
            }
        }
    }
    
    public string LastName
    {
        get { return lastName; }
        set 
        { 
            if (!string.IsNullOrWhiteSpace(value))
            {
                lastName = value;
                email = GenerateEmail(); // Email yangilanadi
            }
        }
    }
    
    public string FullName
    {
        get { return $"{firstName} {lastName}"; }
    }
    
    public string Email
    {
        get { return email; }
    }
    
    public DateTime BirthDate
    {
        get { return birthDate; }
        set 
        { 
            if (value <= DateTime.Now.AddYears(-16)) // 16 yoshdan katta bo'lishi kerak
                birthDate = value;
        }
    }
    
    public int Age
    {
        get 
        { 
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age--;
            return age;
        }
    }
    
    public double GPA
    {
        get 
        { 
            if (grades.Count == 0) return 0;
            return Math.Round(grades.Average(), 2);
        }
    }
    
    public int TotalCredits
    {
        get { return grades.Count * 3; } // Har fan 3 kredit deb hisoblaymiz
    }
    
    // Methods
    private string GenerateEmail()
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            return "";
        return $"{firstName.ToLower()}.{lastName.ToLower()}@university.uz";
    }
    
    public void AddGrade(int grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
            Console.WriteLine($"{FullName}ga {grade} ball qo'shildi.");
        }
        else
        {
            Console.WriteLine("Ball 0-100 oralig'ida bo'lishi kerak!");
        }
    }
    
    public void RemoveLastGrade()
    {
        if (grades.Count > 0)
        {
            int removedGrade = grades.Last();
            grades.RemoveAt(grades.Count - 1);
            Console.WriteLine($"{FullName}dan {removedGrade} ball o'chirildi.");
        }
        else
        {
            Console.WriteLine("O'chirish uchun ball yo'q!");
        }
    }
    
    public List<int> GetAllGrades()
    {
        return new List<int>(grades); // Kopiya qaytarish (encapsulation)
    }
    
    public string GetGradeReport()
    {
        if (grades.Count == 0)
            return $"{FullName}: Hech qanday ball yo'q";
        
        string report = $"\n=== {FullName} ning hisoboti ===\n";
        report += $"Talaba ID: {studentId}\n";
        report += $"Email: {email}\n";
        report += $"Yoshi: {Age}\n";
        report += $"Ballar: [{string.Join(", ", grades)}]\n";
        report += $"GPA: {GPA}\n";
        report += $"Umumiy kreditlar: {TotalCredits}\n";
        report += $"Status: {GetAcademicStatus()}\n";
        
        return report;
    }
    
    public string GetAcademicStatus()
    {
        double gpa = GPA;
        if (gpa >= 85) return "A'lo";
        if (gpa >= 70) return "Yaxshi";
        if (gpa >= 55) return "Qoniqarli";
        return "Qoniqarsiz";
    }
    
    public bool IsHonorStudent()
    {
        return GPA >= 85 && grades.Count >= 10;
    }
    
    // Comparison methods
    public bool IsSameStudent(Student other)
    {
        return this.studentId == other.studentId;
    }
    
    public int CompareGPA(Student other)
    {
        return this.GPA.CompareTo(other.GPA);
    }
    
    // ToString override
    public override string ToString()
    {
        return $"Talaba: {FullName} (ID: {studentId}, GPA: {GPA})";
    }
}

}
