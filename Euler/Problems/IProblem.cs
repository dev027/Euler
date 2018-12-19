namespace Euler.Problems
{
    public interface IProblem
    {
        string Title { get; }
        string Description { get; }
        long Answer { get; }
        long Solve();
        void Display();
    }
}