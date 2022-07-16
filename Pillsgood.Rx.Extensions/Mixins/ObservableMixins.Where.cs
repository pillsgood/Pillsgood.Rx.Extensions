using System.Reactive.Linq;

// ReSharper disable once CheckNamespace
namespace System;

public static partial class ObservableMixins
{
#if !REACTIVE_UI
    public static IObservable<T> WhereNotNull<T>(this IObservable<T?> observable)
    {
        return observable.Where(x => x is not null).Select(x => x!);
    }
#endif

    public static IObservable<T> WhereHasValue<T>(this IObservable<T?> observable) where T : struct
    {
        return observable.Where(x => x.HasValue).Select(x => x!.Value);
    }

    public static IObservable<bool> Where(this IObservable<bool> observable, bool value)
    {
        return observable.Where(x => x == value);
    }

    public static IObservable<T> WhereNot<T>(this IObservable<T> source, Func<T, bool> predicate)
    {
        return source.Where(value => !predicate.Invoke(value));
    }

    public static IObservable<T> WhereNot<T>(this IObservable<T> source, Func<T, int, bool> predicate)
    {
        return source.Where((value, idx) => !predicate.Invoke(value, idx));
    }
}
