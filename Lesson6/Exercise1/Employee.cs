public abstract class Employee : Person
{
    public string? Department { get; set; }
    public double? Salary { get; set; }
    public int? DateHire { get; set; }
    public int? WorkingTime { get; set; }
    public abstract void CalculateBonus();
    public abstract void CalculateVacation();
}