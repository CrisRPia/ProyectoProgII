namespace Library;

using System.Numerics;

public static class Extensions
{
    /// <summary>
    /// Returns a range including 'from' and excluding 'to'.
    /// If step is set to zero, it will instead default to 1.
    /// Modified from this source: https://stackoverflow.com/questions/915745/thoughts-on-foreach-with-enumerable-range-vs-traditional-for-loop/
    /// </summary>
    public static IEnumerable<T> To<T>(this T from, T to, T step = default)
        where T : struct, INumber<T>
    {
        if (T.IsZero(step))
        {
            step = T.One;
        }

        while (
            (step.CompareTo(T.Zero) > 0 == from.CompareTo(to) < 0)
            && !from.Equals(to)
        )
        {
            yield return from;
            from += step;
        }
    }
}
