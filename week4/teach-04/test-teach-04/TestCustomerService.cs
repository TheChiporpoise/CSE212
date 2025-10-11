using NUnit.Framework;
using teach_04;

namespace test_teach_04;

public class TestCustomerService
{
    [Test]
    public void TestCustomerService1()
    {
        // Test 1
        // Scenario: 
        // Expected Result: 
        // Example of creating and using the priority queue

        // Example of creating and using the priority queue
        var service = new CustomerService(0);
        Assert.That(service.MaxSize, Is.EqualTo(10));
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: 
    }

    [Test]
    public void TestCustomerService2()
    {
        // Test 2
        // Scenario: 
        // Expected Result: 
        var service = new CustomerService(10);
        Assert.That(service.ServeCustomer(), Is.Null);
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: 
    }

    [Test]
    public void TestCustomerService3()
    {
        // Test 2
        // Scenario: 
        // Expected Result: 
        var service = new CustomerService(4);
        service.AddNewCustomer("Jakob", "1", "No hablo English");
        var customer = service.ServeCustomer();
        Assert.That(customer, Is.Not.Null);
        Assert.That(customer.Name, Is.EqualTo("Jakob"));
        Assert.That(customer.AccountId, Is.EqualTo("1"));
        Assert.That(customer.Problem, Is.EqualTo("No hablo English"));
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: 
    }

    [Test]
    public void TestCustomerService4()
    {
        // Test 2
        // Scenario: 
        // Expected Result: 
        var service = new CustomerService(1);
        service.AddNewCustomer("Jakob", "1", "No hablo English");
        try
        {
            service.AddNewCustomer("Person2", "2", "Blue screen of death");
            Assert.Fail("Exception expected");
        }
        catch (InvalidOperationException)
        {
            Assert.Pass("Exception received.");
        }

        // Defect(s) Found: 
    }
    
    [Test]
    public void TestCustomerService5()
    {
        // Test 2
        // Scenario: 
        // Expected Result: 
        var service = new CustomerService(4);
        service.AddNewCustomer("Jakob", "1", "No hablo English");
        service.AddNewCustomer("Brad", "2", "Floating point exception");
        var customer1 = service.ServeCustomer();
        var customer2 = service.ServeCustomer();
        Assert.That(customer1, Is.Not.Null);
        Assert.That(customer1.Name, Is.EqualTo("Jakob"));
        Assert.That(customer2, Is.Not.Null);
        Assert.That(customer2.AccountId, Is.EqualTo("Brad"));
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: 
    }

    // TODO Add more test cases as needed to test all of the requirements and find all the bugs
}