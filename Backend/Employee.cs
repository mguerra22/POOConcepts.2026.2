namespace Backend;

public abstract class Employee
{
    // Constructors
    protected Employee(int id, string firstName, string lastName, Date bornDate, Date hireDate, bool isActive)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        BornDate = bornDate;
        HireDate = hireDate;
        IsActive = isActive;
    }

    // Properties
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsActive { get; set; }

    public Date BornDate { get; set; } = null!;

    public Date HireDate { get; set; } = null!;

    // Public Methods
    public abstract decimal GetValueToPay();

    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
            $"Born date......: {BornDate,20}\n\t" +
            $"Hire date......: {HireDate,20}\n\t" +
            $"Salary.........: {GetValueToPay(),20:C2}";
    }
}