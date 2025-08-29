using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

public abstract class Employee
{
    public int Id { get; set; }
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public bool IsActive { get; set; }
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;

    public abstract decimal GetValueToPay();

    public override string ToString() =>
        $"{Id}\t{Firstname} {Lastname}\n\t" +
        $"Hire date..: {HireDate}\n\t" +
        $"Salary.....: {GetValueToPay():C2}";
}