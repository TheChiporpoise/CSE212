using NUnit.Framework;
using prove_05;

namespace test_prove_05;

public class Tests
{
    [Test]
    public void TestUnion1()
    {
        var s1 = new HashSet<int>([1, 2, 3, 4, 5]);
        var s2 = new HashSet<int>([4, 5, 6, 7, 8]);
        Assert.That(SetOperations.Union(s1, s2), Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
    }

    [Test]
    public void TestUnion2()
    {
        var s1 = new HashSet<int>([1, 2, 3, 4, 5]);
        var s2 = new HashSet<int>([6, 7, 8, 9, 10]);
        Assert.That(SetOperations.Union(s1, s2), Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
    }

    [Test]
    public void TestIntersection1()
    {
        var s1 = new HashSet<int>([1, 2, 3, 4, 5]);
        var s2 = new HashSet<int>([4, 5, 6, 7, 8]);
        Assert.That(SetOperations.Intersection(s1, s2), Is.EqualTo(new[] { 4, 5 }));
    }

    [Test]
    public void TestIntersection2()
    {
        var s1 = new HashSet<int>([1, 2, 3, 4, 5]);
        var s2 = new HashSet<int>([6, 7, 8, 9, 10]);
        Assert.That(SetOperations.Intersection(s1, s2), Is.EqualTo(Array.Empty<int>()));
    }

    [Test]
    public void TestFindPairs1()
    {
        var results = SetOperations.FindPairs(["am", "at", "ma", "if", "fi"]);
        var expected = new[] { ("am", "ma"), ("fi", "if") };
        // Is.EquivalentTo(...) ignores order & checks for all pairs
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }

    [Test]
    public void TestFindPairs2()
    {
        var results = SetOperations.FindPairs(["ab", "bc", "cd", "de", "ba"]);
        var expected = new[] { ("ab", "ba") };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }

    [Test]
    public void TestFindPairs3()
    {
        var results = SetOperations.FindPairs(["ab", "ba", "ac", "ad", "da", "ca"]);
        var expected = new[] { ("ab", "ba"), ("ad", "da"), ("ac", "ca") };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }

    [Test]
    public void TestFindPairs4()
    {
        var results = SetOperations.FindPairs(["ab", "ac"]);
        var expected = Array.Empty<(string, string)>();
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }

    [Test]
    public void TestFindPairs5()
    {
        var results = SetOperations.FindPairs(["ab", "aa", "ba"]);
        var expected = new[] { ("ab", "ba") };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }

    [Test]
    public void TestFindPairs6()
    {
        var results = SetOperations.FindPairs(["23", "84", "49", "13", "32", "46", "91", "99", "94", "31", "57", "14"]);
        var expected = new[] { ("23", "32"), ("49", "94"), ("13", "31") };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }
    
    
    [Test]
    public void TestMarkdownDocumentUpdated()
    {
        var responseDocument = new FileInfo("../../../../prove-05/05-prove-response.md");
        Assert.That(responseDocument.Exists, Is.True);
        var sr = new StreamReader(responseDocument.Open(FileMode.Open));
        var textOfWordDocument = sr.ReadToEnd();
        var unchangedDocument =
            "**CSE 212 – Programming with Data Structures**\n\n**W05 Prove – Response Document**\n\n------------------------------------------\n\n_It is a violation of BYU-Idaho Honor Code to post or share this document with others or to post it online.  Storage into a personal and private repository (e.g. private GitHub repository, unshared Google Drive folder) is acceptable._\n\n------------------------------------------\n\n**Question 1:**  From Part 1, how did you answer the interview question for the Set Operations problem (should be no more than 30 seconds if spoken aloud)?\n\n(fill in here)\n\n**Question 2:**  From Part 2, how did you answer the interview question for the Find Pairs problem (should be no more than 30 seconds if spoken aloud)?\n\n(fill in here)\n\n------------------------------------------\n\n_Remember:  Make sure all of your changes are committed and pushed to the `main` branch of your_ **prove-05-[username]** _repository_\n\n_Also, submit this document and a link to your repository in I-Learn_\n";
        Assert.That(textOfWordDocument, Is.Not.EqualTo(unchangedDocument), "You need to edit and save the response document (05-prove-response.md)");
    }
}