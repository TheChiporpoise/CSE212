namespace teach_01;

public static class ArraySelector
{
    public static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int length = Math.Min(list1.Length, list2.Length); // length can't be longer than the shorter list (also solves select being too long)
        length = Math.Min(length, select.Length); // length can't be longer than the select list
        
        List<int> results = new List<int>();

        for (int i = 0; i < length; i++)
        {
            if (select[i] == 1)
            {
                results.Add(list1[i]);
            }
            else if (select[i] == 2)
            {
                results.Add(list2[i]);
            }
        }
        
        return results;
    }

    public static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        return new char[0];
    }
}