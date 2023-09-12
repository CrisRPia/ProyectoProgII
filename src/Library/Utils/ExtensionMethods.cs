namespace Library;

public static class Extensions
{
    /// <summary>
    /// Returns a range including 'from' and excluding 'to'.
    /// Source, modified: https://stackoverflow.com/questions/915745/thoughts-on-foreach-with-enumerable-range-vs-traditional-for-loop/
    /// </summary>
    public static IEnumerable<T> To<T>(this T from, T to, T step = default)
        where T : struct, IComparable<T>
    {
        dynamic current = from;
        dynamic increment = EqualityComparer<T>.Default.Equals(step, default(T))
            ? 1
            : step;

        if (increment == 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(step),
                "step cannot be zero"
            );
        }

        while (
            (increment > 0 == current.CompareTo(to) < 0) && !current.Equals(to)
        )
        {
            yield return current;
            current += increment;
        }
    }
}
