namespace AdaptorPattern;

public class AdapteeBillingService
{
    public void MakePayment(IList<Employee> employees)
    {
        foreach (var employee in employees) 
        {
            Console.WriteLine($"Payment amount £{employee.Salary / 12} sent to {employee.Name}");
        }
    }
}