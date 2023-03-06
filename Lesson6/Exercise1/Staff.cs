public class Staff : Employee
{
    public string? Level { get; set; }
    public override void CalculateBonus()
    {
        base.Salary = base.Salary + 0.06 * base.Salary;
    }
    public override void CalculateVacation()
    {
        if (base.WorkingTime > 5)
        {
            base.DateHire = base.DateHire + 4;
        }
        else
        {
            base.DateHire = base.DateHire + 3;
        }
    }
}