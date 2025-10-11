using NUnit.Framework;
using teach_04;

namespace test_teach_04;

public class TestSimpleQueue
{
    [Test]
    public void TestSimpleQueue1()
    {
        // Test 1
        // Scenario: Enqueue one value and then Dequeue it.
        // Expected Result: It should display 100
        var queue = new SimpleQueue();
        queue.Enqueue(100);
        var result = queue.Dequeue();
        Assert.That(result, Is.EqualTo(100));
        // Defect(s) Found:
    }

    [Test]
    public void TestSimpleQueue2()
    {
        // Test 2
        // Scenario: Enqueue multiple values and then Dequeue all of them
        // Expected Result: It should display 200, then 300, then 400 in that order
        var queue = new SimpleQueue();
        queue.Enqueue(200);
        queue.Enqueue(300);
        queue.Enqueue(400);
        Assert.That(queue.Dequeue(), Is.EqualTo(200));
        Assert.That(queue.Dequeue(), Is.EqualTo(300));
        Assert.That(queue.Dequeue(), Is.EqualTo(400));
        // Defect(s) Found: 
    }

    [Test]
    public void TestSimpleQueue3()
    {
        // Test 3
        // Scenario: Dequeue from an empty Queue
        // Expected Result: An exception should be raised
        var queue = new SimpleQueue();
        try {
            queue.Dequeue();
            Assert.Fail("Oops ... Exception expected.");
        }
        catch (IndexOutOfRangeException) {
            Console.WriteLine("I got the exception as expected.");
        }
        // Defect(s) Found: 
    }
}