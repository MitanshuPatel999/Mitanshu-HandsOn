namespace Evolution{
    class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }=null!;
    public int Age { get; set; }
}

delegate bool FindStudent(Student std);

class StudentExtension
{ 
    public static Student[] where(Student[] stdArray, FindStudent del)
    {
        int i=0;
        Student[] result = new Student[10];
        foreach (Student std in stdArray)
            if (del(std))
            {
                result[i] = std;
                i++;
            }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] studentArray = { 
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 25 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 18 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

        Student[] studentsr = new Student[10];

        int i = 0;

        foreach (Student std in studentArray)
        {
            if (std.Age > 12 && std.Age < 20)
            {
                studentsr[i] = std;
                i++;
            }
        }

        Student[] students = StudentExtension.where(studentArray, delegate(Student std){
                return std.Age > 12 && std.Age < 20;
            });
        
        Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        Student? student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
        Console.WriteLine(student5?.StudentName);
        var teenAgerStudentsLINQ=from s in studentArray where s.Age>12 &&s.Age<20 select s;
        Console.WriteLine(teenAgerStudentsLINQ);
        foreach (var name in teenAgerStudentsLINQ)
        {
            Console.WriteLine(name.StudentName);
        }
        var SortedStudents=studentArray.OrderBy(s=>s.Age);
        Console.WriteLine("\nStudents sorted by age:");
        foreach (var student in SortedStudents)
        {
            Console.WriteLine($"ID:{student.StudentID}, Name:{student.StudentName}, Age:{student.Age}");
        }
        var MaxAge=studentArray.Max(s=>s.Age);
        Console.WriteLine($"MaxAge:{MaxAge}");

        var groupedStudents = studentArray.GroupBy(student => student.Age);

        Console.WriteLine("\nStudents grouped by age:");
        foreach (var group in groupedStudents)
        {
            Console.WriteLine($"Age: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"ID: {student.StudentID}, Name: {student.StudentName}");
            }
        }


   }
}
}