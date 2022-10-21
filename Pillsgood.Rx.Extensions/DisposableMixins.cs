using Pillsgood.Rx.Extensions;

// ReSharper disable once CheckNamespace
namespace System.Reactive.Disposables;

public static class DisposableMixins
{
#if !REACTIVE_UI
    public static T DisposeWith<T>(this T item, CompositeDisposable compositeDisposable)
        where T : IDisposable
    {
        ArgumentNullException.ThrowIfNull(compositeDisposable);
        compositeDisposable.Add(item);
        return item;
    }
#endif

    public static async ValueTask<T> DisposeWithAsync<T>(this T item, CompositeAsyncDisposable compositeDisposable)
        where T : IAsyncDisposable
    {
        ArgumentNullException.ThrowIfNull(compositeDisposable);
        await compositeDisposable.AddAsync(item);
        return item;
    }

    public static T DisposeWith<T>(this T disposable, IDisposableWith with)
        where T : IDisposable
    {
        return disposable.DisposeWith(with.CompositeDisposable);
    }

    public static ValueTask<T> DisposeWithAsync<T>(this T disposable, IAsyncDisposableWith with)
        where T : IAsyncDisposable
    {
        return disposable.DisposeWithAsync(with.CompositeAsyncDisposable);
    }
}
