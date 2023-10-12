using System.Collections;
using System.Linq;

namespace linqFun{
    class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }=null!;
    public int Age { get; set; }
    public String Department { get; set; }=null!;
}

    class Department
{
    public int DID { get; set; }
    public String DepartmentName { get; set; }=null!;
}

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = { 
            new Student() { StudentID = 1, StudentName = "John", Age = 18, Department="CE" },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 25, Department="ME" },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25, Department="IT" },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, Department="CE" },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31, Department="ME" },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 18, Department="CE" },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19, Department="IT"  },
            new Student() { StudentID = 8, StudentName = "Ram" , Age = 21, Department="CE" },

        };

        IList<Department> departmentList = new List<Department>() { 
        new Department(){ DID = 1, DepartmentName="CE"},
        new Department(){ DID = 2, DepartmentName="IT"},
        new Department(){ DID = 3, DepartmentName="EE"}
    };

        var ts=from s in studentArray
               where s.Age>12 && s.Age<20
               select s;
        foreach(var i in ts){
            Console.WriteLine(i.StudentID+", "+i.StudentName);
        }
        
        IList mixedList = new ArrayList();
        mixedList.Add(0);
        mixedList.Add("One");
        mixedList.Add("Two");
        mixedList.Add(3);
        mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

        var stringResult = from s in mixedList.OfType<string>()
                           select s;
        foreach(var j in stringResult){
            Console.WriteLine(j);
        }
        
        var obs=from s in studentArray
                orderby s.Age
                select s;
        foreach(var j in obs){
            Console.WriteLine(j.StudentID+", "+j.StudentName+", "+j.Age);
        }
        Console.WriteLine("OrderBy.ThenBy");
        var obtbs=studentArray.OrderBy(s=>s.StudentName).ThenBy(s=>s.Age).ToList();
        foreach(var j in obtbs){
            Console.WriteLine(j.StudentID+", "+j.StudentName+", "+j.Age);
        }
        Console.WriteLine("OrderBy.ThenByDescending");
        var obtbds=studentArray.OrderBy(s=>s.StudentName).ThenByDescending(s=>s.Age).ToList();
        foreach(var j in obtbds){
            Console.WriteLine(j.StudentID+", "+j.StudentName+", "+j.Age);
        }

        Console.WriteLine("GroupBy");
        var gsd=from s in studentArray
                group s by s.Department;
        foreach(var group in gsd){
            Console.WriteLine(group.Key);
            foreach(var i in group)
                Console.WriteLine(i.StudentID+", "+i.StudentName);
        }

        Console.WriteLine("Join");
        var joinsd=from s in studentArray
                   join d in departmentList on s.Department equals d.DepartmentName
                   select new{ Name=s.StudentName,Age=s.Age,DID=d.DID};
        foreach(var j in joinsd){
            Console.WriteLine(j.Name+", "+j.Age+", "+j.DID);
        }

        var groupJoinQuery = from dept in departmentList
                             join student in studentArray on dept.DepartmentName equals student.Department into studentsInDepartment
                             select new
                             {
                                 DepartmentName = dept.DepartmentName,
                                 Students = studentsInDepartment
                             };

        foreach (var department in groupJoinQuery)
        {
            Console.WriteLine($"Department: {department.DepartmentName}");
            foreach (var student in department.Students)
            {
                Console.WriteLine($"- Student Name: {student.StudentName}, Age: {student.Age}");
            }
            Console.WriteLine();
        }
        var SelectR=studentArray.Select(s=>new {Name="Mr."+s.StudentName,Age=s.Age});
        foreach(var j in SelectR){
            Console.WriteLine(j.Name+", "+j.Age);
        }

        bool areAllStudentsTeenAger = studentArray.All(s => s.Age > 12 && s.Age < 20);
        Console.WriteLine(areAllStudentsTeenAger);

        bool areAnyStudentsTeenAger = studentArray.All(s => s.Age > 12 && s.Age < 20);
        Console.WriteLine(areAnyStudentsTeenAger);

        string commaSeparatedStudentNames = studentArray.Aggregate<Student, string>(
                                                "Student Names: ",
                                                (str, s) => str += s.StudentName + "," ); 

        Console.WriteLine(commaSeparatedStudentNames);

        var avgAge = studentArray.Average(s => s.Age);
        Console.WriteLine("Average Age of Students: {0}", avgAge);

        var MaxAge = studentArray.Max(s => s.Age);
        Console.WriteLine("Maximum Age of Students: {0}", MaxAge);

        var SumAge = studentArray.Sum(s => s.Age);
        Console.WriteLine("Total Age of Students: {0}", SumAge);

    }
    }
}
