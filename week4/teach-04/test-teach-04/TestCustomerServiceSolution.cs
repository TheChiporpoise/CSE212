using NUnit.Framework;
using teach_04;
using teach_04.solutions;

namespace test_teach_04;

public class TestCustomerServiceSolution
{
    [Test]
    public void TestCustomerServiceSolution1()
    {
        // Test 1
        // Scenario: Can I add one customer and then serve the customer?
        // Expected Result: This should display the customer that was added
        // Example of creating and using the priority queue
        var service = new CustomerServiceSolution(4);
        service.AddNewCustomer("John", "1234", "Mouse doesn't work");
        var customer = service.ServeCustomer();
        Assert.That(customer, Is.Not.Null);
        Assert.That(customer.Name, Is.EqualTo("John"));
        Assert.That(customer.AccountId, Is.EqualTo("1234"));
        Assert.That(customer.Problem, Is.EqualTo("Mouse doesn't work"));
        // Defect(s) Found: This found that the ServeCustomer should get the customer before deleting from the list
    }

    [Test]
    public void TestCustomerServiceSolution2()
    {
        // Test 2
        // Scenario: Can I add two customers and then serve the customers in the right order?
        // Expected Result: This should display the customers in the same order that they were entered
        var service = new CustomerServiceSolution(4);
        service.AddNewCustomer("John", "1234", "Mouse doesn't work");
        service.AddNewCustomer("Mary", "2345", "Keyboard doesn't work");
        Console.WriteLine($"Before serving customers: {service}");
        Assert.That(service.ServeCustomer()!.Name, Is.EqualTo("John"));
        Assert.That(service.ServeCustomer()!.Name, Is.EqualTo("Mary"));
        Console.WriteLine($"After serving customers: {service}");
        // Defect(s) Found: None :)
    }

    [Test]
    public void TestCustomerServiceSolution3()
    {
        // Test 3
        // Scenario: Can I serve a customer if there is no customer?
        // Expected Result: This should display some error message and return null
        var service = new CustomerServiceSolution(4);
        Assert.That(service.ServeCustomer(), Is.Null);
        // Defect(s) Found: This found that I need to check the length in serve_customer and display an error message
    }

    [Test]
    public void TestCustomerServiceSolution4()
    {
        // Test 4
        // Scenario: Does the max queue size get enforced?
        // Expected Result: This should display some error message when the 5th one is added
        var service = new CustomerServiceSolution(4);
        service.AddNewCustomer("One", "1", "Mouse doesn't work");
        service.AddNewCustomer("Two", "2", "Mouse doesn't work");
        service.AddNewCustomer("Three", "3", "Mouse doesn't work");
        service.AddNewCustomer("Four", "4", "Mouse doesn't work");
        try
        {
            service.AddNewCustomer("Five", "5", "Mouse doesn't work");
            Assert.Fail("Exception expected");
        }
        catch (InvalidOperationException)
        {
            Assert.Pass("Exception received.");
        }
        // Defect(s) Found: This found that I need to do >= instead of > in AddNewCustomer
    }

    [Test]
    public void TestCustomerServiceSolution5()
    {
        // Test 5
        // Scenario: Does the max size get defaulted to 10 if an invalid value is provided?
        // Expected Result: It should display 10
        var service = new CustomerServiceSolution(0);
        Assert.That(service.MaxSize, Is.EqualTo(10));
        // Defect(s) Found: None :)
    }

    // TODO Add more test cases as needed to test all of the requirements and find all the bugs
}