namespace TimeComplexity;

public abstract class CyclicRotation
{
    // [1,2,3,4]
    public static int[] Solve(int[] A, int K)
    {
        return Enumerable.Range(0, K).Aggregate(A, (current, i) => CyclicOnce(current, K));
    }

    private static int[] CyclicOnce(int[] A, int K)
    {
        var newList = new int[A.Length];
        newList[0] = A[^1];
        for (int i = 0; i < A.Length - 1; i++)
        {
            newList[i + 1] = A[i];
        }

        return newList;
    }
}