using System.Reactive;
using System.Reactive.Linq;

// ReSharper disable once CheckNamespace
namespace System;

public static partial class ObservableMixins
{
    public static IObservable<Unit> AsUnit<T>(this IObservable<T> source)
    {
        return source.Select(_ => Unit.Default);
    }
}
