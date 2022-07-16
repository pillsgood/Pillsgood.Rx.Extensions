using System.Reactive.Linq;

// ReSharper disable once CheckNamespace
namespace System;

public static partial class ObservableMixins
{
    public static IObservable<T> SelectMany<T>(this IObservable<IEnumerable<T>> observable)
    {
        return observable.SelectMany(items => items);
    }

    public static IObservable<T> SelectMany<T>(this IObservable<IObservable<T>> observable)
    {
        return observable.SelectMany(items => items);
    }
}
