namespace Backend;

public class SalaryEmployee : Employee
{
    // Fields
    private decimal _salary;

    // Constructors
    public SalaryEmployee(int id, string firstName, string lastName, Date bornDate, Date hireDate, bool isActive, decimal salary)
        : base(id, firstName, lastName, bornDate, hireDate, isActive)
    {
        Salary = salary;
    }

    // Properties
    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    // Public methods
    public override decimal GetValueToPay() => _salary;

    // Private methods
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 2000000)
        {
            throw new Exception($"The salary: {salary:C2}, is less than the minimum.");
        }
        return salary;
    }
}