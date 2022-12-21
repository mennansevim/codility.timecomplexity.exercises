namespace TimeComplexity;

public abstract class OddsInArray
{
    public static int[] Solve(int[] A)
    {
        // {9,3,9,4,3,9,8}
        var unPairedListIndexes = new List<int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (Count(A, A[i]) % 2 != 0)
            {
                if (!unPairedListIndexes.Contains(A[i]))
                    unPairedListIndexes.Add(A[i]);
            }
        }

        return unPairedListIndexes.ToArray();
    }

    static int Count(int[] A, int key)
    {
        var counter = 0;
        foreach (var t in A)
        {
            if (t == key)
            {
                counter++;
            }
        }

        return counter;
    }
}