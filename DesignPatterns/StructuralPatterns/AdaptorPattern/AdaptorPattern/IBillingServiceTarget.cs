namespace AdaptorPattern;

public interface IBillingServiceTarget
{
    void ProcessEmployeeMonthlyPayments(Employee[] employees);
}