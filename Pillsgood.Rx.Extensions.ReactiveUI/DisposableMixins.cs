using Pillsgood.Rx.Extensions;

// ReSharper disable once CheckNamespace
namespace System.Reactive.Disposables;

public static class DisposableMixins
{
    public static T DisposeWith<T>(this T disposable, IDisposableWith with)
        where T : IDisposable
    {
        return disposable.DisposeWith(with.CompositeDisposable);
    }
}
