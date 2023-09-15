namespace Library;

using System.Numerics;

public static class Extensions
{
    /// <summary>
    /// Returns a range including 'from' and excluding 'to'.
    /// The ranges shift in intervals of T.One or -T.One.
    /// Modified from this source: https://stackoverflow.com/questions/915745/thoughts-on-foreach-with-enumerable-range-vs-traditional-for-loop/
    /// </summary>
    public static IEnumerable<T> To<T>(this T from, T to)
        where T : struct, INumber<T>
    {
        T step = from.CompareTo(to) switch {
            < 0 => T.One,
            >= 0 => -T.One,
        };

        while (from < to)
        {
            yield return from;
            from += T.One;
        }
    }

    /// <summary>
    /// Returns a range including 'from' and excluding 'to'.
    /// If step is set to default(T) (no step param), it will instead default to
    /// 1.
    /// Modified from this source: https://stackoverflow.com/questions/915745/thoughts-on-foreach-with-enumerable-range-vs-traditional-for-loop/
    /// </summary>
    /// <exception cref="ArgumentException">
    /// If step is T.Zero
    /// </exception>
    public static IEnumerable<T> To<T>(this T from, T to, T step = default)
        where T : struct, INumber<T>
    {
        if (step == default(T))
            step = T.One;
        else if (T.IsZero(step))
            throw new ArgumentException();

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
