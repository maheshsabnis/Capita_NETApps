﻿using System;
using System.Collections.Generic;

namespace CS_EFCore_DbFirst.Models;

public partial class Employee
{
    public int EmpNo { get; set; }

    public string EmpName { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int DeptNo { get; set; }

    public virtual Department DeptNoNavigation { get; set; } = null!;
}
