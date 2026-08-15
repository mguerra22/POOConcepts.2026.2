using System.ComponentModel;

namespace Backend;

public class CommissionEmployee : Employee
{
    // Fields
    private float _commissionPercentage;
    private decimal _sales;

    // Constructors
    public CommissionEmployee(int id, string firstName, string lastName, Date bornDate, Date hireDate, bool isActive, float commissionPercentage, decimal sales) : base(id, firstName, lastName, bornDate, hireDate, isActive)
    {
        CommissionPercentage = commissionPercentage;
        Sales = sales;
    }

    // Properties
    public float CommissionPercentage
    {
        get => _commissionPercentage;
        set => _commissionPercentage = ValidateCommissionPercentage(value);
    }

    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }

    // Public methods
    public override decimal GetValueToPay() => _sales * (decimal)_commissionPercentage;

    // Private methods
    private float ValidateCommissionPercentage(float commissionPercentage)
    {
        if (commissionPercentage < 0 || commissionPercentage > 0.3)
        {
            throw new Exception($"The commission percentage: {commissionPercentage:P2}, is not valid.");
        }
        return commissionPercentage;
    }

    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new Exception($"The sales: {sales:C2}, is not valid.");
        }
        return sales;
    }
}