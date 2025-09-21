using NUnit.Framework;
using teach_01;
using teach_01.solutions;

public class Tests
{
    [Test]
    public void TestDivisors1()
    {
        var result = Divisors.FindDivisors(80);
        var expected = new[] { 1, 2, 4, 5, 8, 10, 16, 20, 40 };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestDivisors2()
    {
        var result = Divisors.FindDivisors(79);
        var expected = new[] { 1 };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestDivisorsSolution1()
    {
        var result = DivisorsSolution.FindDivisors(80);
        var expected = new[] { 1, 2, 4, 5, 8, 10, 16, 20, 40 };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestDivisorsSolution2()
    {
        var result = DivisorsSolution.FindDivisors(79);
        var expected = new[] { 1 };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestArraySelector1()
    {
        var array1 = new[] { 1, 2, 3, 4, 5 };
        var array2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var result = ArraySelector.ListSelector(array1, array2, select);
        var expected = new[] { 1, 2, 3, 2, 4, 4, 6, 8, 10, 5 };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestArraySelector2()
    {
        var array1 = new[] { 'A', 'A', 'A', 'A', 'A' };
        var array2 = new[] { 'B', 'B', 'B', 'B', 'B' };
        var select = new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
        var result = ArraySelector.ListSelector(array1, array2, select);
        var expected = new[] { 'A', 'B', 'A', 'B', 'A', 'B', 'A', 'B', 'A', 'B' };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestArraySelectorSolution1()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var result = ArraySelectorSolution.ListSelector(l1, l2, select);
        var expected = new[] { 1, 2, 3, 2, 4, 4, 6, 8, 10, 5 };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestArraySelectorSolution2()
    {
        var l3 = new[] { 'A', 'A', 'A', 'A', 'A' };
        var l4 = new[] { 'B', 'B', 'B', 'B', 'B' };
        var select = new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
        var result = ArraySelectorSolution.ListSelector(l3, l4, select);
        var expected = new[] { 'A', 'B', 'A', 'B', 'A', 'B', 'A', 'B', 'A', 'B' };
        Assert.That(result, Is.EqualTo(expected));
    }
}