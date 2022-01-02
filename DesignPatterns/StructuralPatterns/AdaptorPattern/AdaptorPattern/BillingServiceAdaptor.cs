namespace AdaptorPattern;

public class BillingServiceAdaptor : IBillingServiceTarget
{
    private readonly AdapteeBillingService adapteeBillingService;

    public BillingServiceAdaptor(AdapteeBillingService adapteeBillingService)
    {
        this.adapteeBillingService = adapteeBillingService;
    }

    public void ProcessEmployeeMonthlyPayments(Employee[] employees)
    {
        adapteeBillingService.MakePayment(employees.ToList());
    }
}