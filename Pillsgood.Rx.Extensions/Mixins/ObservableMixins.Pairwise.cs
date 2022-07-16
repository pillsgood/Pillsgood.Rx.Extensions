using Pillsgood.Rx.Extensions;
using Pillsgood.Rx.Extensions.Operators;

// ReSharper disable once CheckNamespace
namespace System;

public static partial class ObservableMixins
{
    public static IObservable<TR> Pairwise<T, TR>(this IObservable<T> source, Func<Pair<T>, TR> selector)
    {
        return new PairwiseObservable<T, TR>(source, selector);
    }

    public static IObservable<Pair<T>> Pairwise<T>(this IObservable<T> source)
    {
        return new PairwiseObservable<T>(source);
    }
}
