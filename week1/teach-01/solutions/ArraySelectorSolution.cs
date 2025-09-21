namespace teach_01.solutions;

public static class ArraySelectorSolution
{
    public static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var result = new int[select.Length];
        var l1Idx = 0;
        var l2Idx = 0;
        for (var i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
                result[i] = list1[l1Idx++];
            else
                result[i] = list2[l2Idx++];
        }

        return result;
    }

    public static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        var result = new char[select.Length];
        var l1Idx = 0;
        var l2Idx = 0;
        for (var i = 0; i < select.Length; i++)
        {
            result[i] = select[i] == 1 ? list1[l1Idx++] : list2[l2Idx++];
        }

        return result;
    }
}