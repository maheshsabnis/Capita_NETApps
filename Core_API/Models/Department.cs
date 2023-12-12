using Core_API.Models.CustomModelValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core_API.Models;

public partial class Department : EntityBase
{
    [Required(ErrorMessage ="DeptNo is required")]
    public int DeptNo { get; set; }
    [Required(ErrorMessage = "DeptName is required")]
    public string DeptName { get; set; } = null!;
    [Required(ErrorMessage = "Location is required")]
    public string Location { get; set; } = null!;
    [Required(ErrorMessage = "Capacity is required")]
    [NumericNonNetgative(ErrorMessage ="Capacity Cannot be -VE")]
    public int Capacity { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
