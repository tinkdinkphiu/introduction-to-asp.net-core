using System;
using System.Collections.Generic;

namespace FuhoWeb.Models;

public partial class Employee
{
    public string EmployeeId { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public string? Position { get; set; }

    public string? Image { get; set; }
}
