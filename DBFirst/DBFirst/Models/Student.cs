using System;
using System.Collections.Generic;

namespace DBFirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public DateTime? JoinDate { get; set; }
}
