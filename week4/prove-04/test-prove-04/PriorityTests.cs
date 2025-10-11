using NUnit.Framework;
using prove_04;

public class PriorityTests
{
    [Test]
    public void TestPriority1()
    {
        // Test 1
        // Scenario: An item is added to the back of the queue
        // Expected Result: The items should be in the order they were added
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);
        Assert.That(priorityQueue.ToString(), Is.EqualTo("[A (Pri:1), B (Pri:2), C (Pri:3)]"));
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: None, only thing I wasn't familiar with was how nodes are stringified
    }

    [Test]
    public void TestPriority2()
    {
        // Test 2
        // Scenario: An item is added to the back of the queue, then the queue is dequeued
        // Expected Result: The reesult of the dequeue should be the item with the highest priority, the queue should contain the remaining items in the order they were added
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);
        Assert.That(priorityQueue.Dequeue(), Is.EqualTo("C"));
        Assert.That(priorityQueue.ToString(), Is.EqualTo("[A (Pri:1), B (Pri:2)]"));
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: Index of the for loop in Dequeue should start at 0, not 1 and be less than count rather than one less than count
    }

    [Test]
    public void TestPriority3()
    {
        // Test 3
        // Scenario: Two items are added to the back of the queue, then the queue is dequeued
        // Expected Result: The reesult of the dequeue should be the item with the highest priority, the queue should contain the remaining items in the order they were added
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 3);
        Assert.That(priorityQueue.Dequeue(), Is.EqualTo("B"));
        Assert.That(priorityQueue.ToString(), Is.EqualTo("[A (Pri:1), C (Pri:3)]"));
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: Index of the for loop in Dequeue should start at 0, not 1 and be less than count rather than one less than count. Also the comparison should be > rather than >= to ensure that the first item with the highest priority is dequeued
    }

    [Test]
    public void TestPriority4()
    {
        // Test 4
        // Scenario: An emypty queue is dequeued
        // Expected Result: An error message is displayed and null is returned

        var priorityQueue = new PriorityQueue(); // Example of creating and using the priority queue
        try
        {
            var result = priorityQueue.Dequeue();
            Assert.Fail("Expected an InvalidOperationException to be thrown.");
        }
        catch (InvalidOperationException error)
        {
            Assert.That(error.Message, Is.EqualTo("Queue Empty."));
        }
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: 
    }

    // TODO Add more test cases as needed to test all of the requirements and find all the bugs
}