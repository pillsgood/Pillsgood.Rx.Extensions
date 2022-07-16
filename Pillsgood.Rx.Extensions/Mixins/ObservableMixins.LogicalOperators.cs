using System.Reactive.Linq;

// ReSharper disable once CheckNamespace
namespace System;

public static partial class ObservableMixins
{
    public static IObservable<bool> Negate(this IObservable<bool> observable)
    {
        return observable.Select(value => !value);
    }

    public static IObservable<bool> And(this IObservable<bool> left, IObservable<bool> right)
    {
        return left.CombineLatest(right, (l, r) => l && r);
    }

    public static IObservable<bool> And(this IObservable<bool> left, bool right)
    {
        return left.Select(l => l && right);
    }

    public static IObservable<bool> Or(this IObservable<bool> left, IObservable<bool> right)
    {
        return left.CombineLatest(right, (l, r) => l || r);
    }

    public static IObservable<bool> Or(this IObservable<bool> left, bool right)
    {
        return left.Select(l => l || right);
    }
}
