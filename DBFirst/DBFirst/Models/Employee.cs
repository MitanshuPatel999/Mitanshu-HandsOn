using System;
using System.Collections.Generic;

namespace DBFirst.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public decimal? Salary { get; set; }

    public virtual Department? Department { get; set; }
}
