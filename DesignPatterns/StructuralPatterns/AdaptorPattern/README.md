# Adaptor Pattern (Also known as a Wrapper)

## Purpose

Take this scenario. You have an existing, working application that has existed for some time and therefore the code and behaviour is mature and complex. We want to migrate the implementation of some existing functionality, but the existing functionality is obligated to be specific as it is contracted to an interface. The implementation that we want to replace it with achieves the very same goal, however the method signatures are entirely different, which would upset our interface and any other object that consumes it.

The adaptor pattern solves this problem by creating an intermediate object, the adaptor, which is responsible for adapting the new logic to adhere to the contract of the existing interface.

## Example

### Consuming object

We have a HR system that makes payments to employees at the end of the month.

```c#
public class HumanResources
{
    private readonly Employee[] employees;
    private readonly IBillingServiceTarget billingService;

    public HumanResources(IBillingServiceTarget billingService)
    {
        this.billingService = billingService;
        this.employees = this.GetEmployees();
    }

    // The object we are concerned with in this example
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
```
### Existing service (client)

The existing billing service implementation contracted to ```IBillingTarget```, we want to change this in favour of a new implementation -

```c#
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
```
### Replacement service/client (adaptee)

The new service we want to use. It can't be contracted to ```IBillingTarget``` as the method signatures are different, but for various reasons we cannot modify this class, maybe it has other objects that are depending on this, it is not within our control or it is part of an external library/resource -

```c#
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
```

### Adapter

1. The adapter is contracted to the ```IBillingTarget```, and this means we can replace the implementations for ```IBillingTarget``` inside of our ```HumanResources``` object.
2. We inject the new class ```AdapteeBillingService``` into our ```BillingServiceAdaptor``` through its constructor.
3. We then act on our ```AdapteeBillingService``` from within our methods contracted from the ```IBillingTarget```.

```c#
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
```

## Summary

This was slighty confusing to me to begin with, all I could think of is *why can't we just create a replacement implementation that is contracted to the same interface? Why do we need the adaptor at all?*. The answer is simple. The focus here is that we are **unable to modify/access the code we want to consume** or maybe it is contracted to another interface and has it's own chain of dependencies. Whatever the reason, the sulution is simple. Wrap the code you want to consume in another object that implements the same interface as your existing client.