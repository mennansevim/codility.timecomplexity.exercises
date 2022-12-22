namespace TimeComplexity;

public abstract class FrogJump
{
    // X=10
    // Y=85
    // D=30
    public static int Solve(int X, int Y, int D)
    {
        var distance = Y - X;

        // 75 / 30 = 2
        var steps = distance / D;
        var leftOver = distance - (steps * D);
        return leftOver == 0 ? steps : steps + 1;
    }
}