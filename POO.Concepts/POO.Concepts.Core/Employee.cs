namespace POO.Concepts.Core;

public abstract class Employee : IPay
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
        $"Born date.....: {BornDate}\n\t" +
        $"Hire date.....: {HireDate}";
}