namespace AdaptorPattern;

public class BillingService : IBillingTarget
{
    public void ProcessEmployeeMonthlyPayments(Employee[] employees)
    {
        foreach (var employee in employees) 
        {
            this.ProcessPayment(employee);
        }
    }

    private void ProcessPayment(Employee employee)
    {
        Console.WriteLine($"Payment amount £{employee.Salary / 12} sent to {employee.Name}");
    }
}