using NUnit.Framework;
using teach_04;

namespace test_teach_04;

public class TestSimpleQueueSolution
{
    [Test]
    public void TestSimpleQueueSolution1()
    {
        // Test 1
        // Scenario: Enqueue one value and then Dequeue it.
        // Expected Result: It should display 100
        var queue = new SimpleQueueSolution();
        queue.Enqueue(100);
        var result = queue.Dequeue();
        Assert.That(result, Is.EqualTo(100));
        // Defect(s) Found: Trying to remove data from index 1 rather than 0
    }

    [Test]
    public void TestSimpleQueueSolution2()
    {
        // Test 2
        // Scenario: Enqueue multiple values and then Dequeue all of them
        // Expected Result: It should display 200, then 300, then 400 in that order
        var queue = new SimpleQueueSolution();
        queue.Enqueue(200);
        queue.Enqueue(300);
        queue.Enqueue(400);
        Assert.That(queue.Dequeue(), Is.EqualTo(200));
        Assert.That(queue.Dequeue(), Is.EqualTo(300));
        Assert.That(queue.Dequeue(), Is.EqualTo(400));
        // Defect(s) Found: The enqueue was inserting at the front of the queue
    }

    [Test]
    public void TestSimpleQueueSolution3()
    {
        // Test 3
        // Scenario: Dequeue from an empty Queue
        // Expected Result: An exception should be raised
        var queue = new SimpleQueueSolution();
        try {
            queue.Dequeue();
            Assert.Fail("Oops ... Exception expected.");
        }
        catch (IndexOutOfRangeException) {
            Console.WriteLine("I got the exception as expected.");
        }
        // Defect(s) Found: None :)
    }
}