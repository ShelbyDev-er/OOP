public class Faculty : Employee
{
    public string? rank { get; set; }
    public override void CalculateBonus()
    {
        base.Salary = 1000 + 0.05 * base.Salary;
    }
    public override void CalculateVacation()
    {
        if (base.WorkingTime > 3)
        {
            base.DateHire = base.DateHire + 5;
        }
        else if (this.rank == "Senior")
        {
            base.DateHire = base.DateHire + 6;
        }
        else
        {
            base.DateHire = base.DateHire + 4;
        }
    }
}