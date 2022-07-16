using System.Reactive.Disposables;
using System.Reactive.Linq;

// ReSharper disable once CheckNamespace
namespace System;

public static partial class ObservableMixins
{
    public static IObservable<T> DisposeMany<T>(this IObservable<T> source) where T : IDisposable
    {
        return Observable.Create<T>(observer =>
        {
            var locker = new object();
            var latest = default(T);
            var subscriber = source.Synchronize(locker)
                .Do(current => latest = current)
                .Scan((previous, current) =>
                {
                    var dispose = previous as IDisposable;
                    dispose?.Dispose();
                    return current;
                })
                .SubscribeSafe(observer);

            return Disposable.Create(() =>
            {
                subscriber.Dispose();
                lock (locker)
                {
                    latest?.Dispose();
                }
            });
        });
    }
}
