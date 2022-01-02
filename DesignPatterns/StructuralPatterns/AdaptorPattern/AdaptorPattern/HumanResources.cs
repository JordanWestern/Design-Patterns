namespace AdaptorPattern;

public class HumanResources
{
    private readonly Employee[] employees;
    private readonly IBillingServiceTarget billingService;

    public HumanResources(IBillingServiceTarget billingService)
    {
        this.billingService = billingService;
        this.employees = this.GetEmployees();
    }

    public void PayEmployees()
    {
        this.billingService.ProcessEmployeeMonthlyPayments(this.GetActiveEmployees());
    }

    private Employee[] GetEmployees()
    {
        return new Employee[]
        {
            new Employee("Jane Smith", 45000, EmployeeStatus.Active),
            new Employee("Dave Hall", 33000, EmployeeStatus.Active),
            new Employee("Peter Jones", 50000, EmployeeStatus.Active),
            new Employee("Clair Stevenson", 120000, EmployeeStatus.Active),
            new Employee("Paul Newman", 120000, EmployeeStatus.OnLeave)
        };
    }

    private Employee[] GetActiveEmployees()
    {
        return employees.Where(e => e.Status.Equals(EmployeeStatus.Active)).ToArray();
    }
}