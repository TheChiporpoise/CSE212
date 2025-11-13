namespace prove_09;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        Data = data;
    }

    public void Insert(int value)
    {
        if (Contains(value)) // If value exists, exit function
            return;
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if (value == Data) // Value found
        {
            return true;
        }
        else if (value < Data) // look left
        {
            if (Left is null)
                return false; // If left does not exist, value not found
            else
                return Left.Contains(value);
        }
        else if (value > Data) // look right
        {
            if (Right is null)
                return false; // If right does not exist, value not found
            else
                return Right.Contains(value); // Check right subtree
        }
        return false; // return false otherwise
    }

    public int GetHeight(int currentHeight = 0) {
        if (Left is null && Right is null)
        {
            return 1; // if only node
        }

        int leftHeight = 0; // initialize as 0
        if (Left is not null) // if left child exists
        {
            leftHeight = Left.GetHeight(currentHeight + 1); // recursive call to the left with currentHeight incremented
        }

        int rightHeight = 0; // initialize as 0
        if (Right is not null) // if right child exists
        {
            rightHeight = Right.GetHeight(currentHeight + 1);  // recursive call to the right with currentHeight incremented
        }

        return Math.Max(leftHeight, rightHeight) + 1; // return largest height and add one to account for height of current node
    }
}