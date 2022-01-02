namespace AdaptorPattern;

public interface IBillingTarget
{
    void ProcessEmployeeMonthlyPayments(Employee[] employees);
}