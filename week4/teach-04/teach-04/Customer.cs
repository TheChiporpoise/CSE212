namespace teach_04;

/// <summary>
/// Defines a Customer record for the service queue.
/// </summary>
public class Customer
{
    public Customer(string name, string accountId, string problem)
    {
        Name = name;
        AccountId = accountId;
        Problem = problem;
    }

    public string Name { get; }
    public string AccountId { get; }
    public string Problem { get; }

    public override string ToString()
    {
        return $"{Name} ({AccountId}) : {Problem}";
    }
}