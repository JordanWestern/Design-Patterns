using AdaptorPattern;

//--Existing 'legacy service' implementation--

//IBillingTarget billingTarget = new BillingService();
//HumanResources humanResources = new HumanResources(billingTarget);
//humanResources.PayEmployees();

//--------------------------------------------

//--New billing service implementation using adaptor--
AdapteeBillingService adapteeBillingService = new AdapteeBillingService();
IBillingServiceTarget billingTarget = new BillingServiceAdaptor(adapteeBillingService);

HumanResources humanResources = new HumanResources(billingTarget);

humanResources.PayEmployees();
//--------------------------------------------