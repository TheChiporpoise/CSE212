namespace teach_04.solutions;
/*
 * CSE212
 * (c) BYU-Idaho
 * 04-Teach - Problem 2
 *
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */

/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerServiceSolution
{
    private readonly List<Customer> _queue = new();

    public int Count => _queue.Count;
    public int MaxSize { get; }

    public CustomerServiceSolution(int maxSize)
    {
        if (maxSize <= 0)
            MaxSize = 10;
        else
            MaxSize = maxSize;
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// <exception cref="InvalidOperationException">When the maximum number of customers is reached</exception>
    /// </summary>
    public void AddNewCustomer(string name, string accountId, string problem)
    {
        // Verify there is room in the service queue
        // if (_queue.Count > _maxSize) // Defect 3 - should use >=
        if (_queue.Count >= MaxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            throw new InvalidOperationException("Maximum Number of Customers in Queue.");
        }

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }


    /// <summary>
    /// Dequeue the next customer and display the information.
    /// <returns><see cref="Customer"/> if a customer was served otherwise <c>null</c></returns>
    /// </summary>
    public Customer? ServeCustomer()
    {
        // Need to check if there are customers in our queue
        if (_queue.Count <= 0) // Defect 2 - Need to check queue length
        {
            Console.WriteLine("No Customers in the queue");
            return null;
        }

        // Need to read and save the customer before it is deleted from the queue
        var customer = _queue[0];
        _queue.RemoveAt(0); // Defect 1 - Delete should be done after
        Console.WriteLine(customer);
        return customer;
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={MaxSize} => " + String.Join(", ", _queue) + "]";
    }
}