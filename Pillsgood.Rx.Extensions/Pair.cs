namespace Pillsgood.Rx.Extensions;

public readonly struct Pair<T> : IEquatable<Pair<T>>
{
    public T Previous { get; }

    public T Current { get; }

    public Pair(T previous, T current)
    {
        Previous = previous;
        Current = current;
    }

    public override int GetHashCode()
    {
        var comparer = EqualityComparer<T>.Default;

        var h0 = comparer.GetHashCode(Previous!);
        h0 = ((h0 << 5) + h0) ^ comparer.GetHashCode(Current!);
        return h0;
    }

    public override bool Equals(object obj)
    {
        return obj is Pair<T> pair && Equals(pair);
    }

    public bool Equals(Pair<T> other)
    {
        var comparer = EqualityComparer<T>.Default;

        return comparer.Equals(Previous, other.Previous) &&
               comparer.Equals(Current, other.Current);
    }

    public override string ToString()
    {
        return $"({Previous}, {Current})";
    }

    public static bool operator ==(Pair<T> left, Pair<T> right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Pair<T> left, Pair<T> right)
    {
        return !(left == right);
    }
}
