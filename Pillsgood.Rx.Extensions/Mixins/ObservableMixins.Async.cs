using System.Reactive.Linq;

// ReSharper disable once CheckNamespace
namespace System;

public static class ObservableMixinsAsync
{
    public static IDisposable Subscribe<T>(
        this IObservable<T> source,
        Func<T, Task> onNext)
    {
        return source.Select(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Concat()
            .Subscribe();
    }

    public static IDisposable Subscribe<T>(
        this IObservable<T> source,
        Func<T, Task> onNext,
        Action onCompleted)
    {
        return source.Select(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Concat()
            .Subscribe(_ => { }, onCompleted);
    }

    public static IDisposable Subscribe<T>(
        this IObservable<T> source,
        Func<T, Task> onNext,
        Action<Exception> onError)
    {
        return source.Select(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Concat()
            .Subscribe(_ => { }, onError);
    }

    public static IDisposable Subscribe<T>(
        this IObservable<T> source,
        Func<T, Task> onNext,
        Action<Exception> onError,
        Action onCompleted)
    {
        return source.Select(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Concat()
            .Subscribe(_ => { }, onError, onCompleted);
    }

    public static IDisposable Subscribe<T>(this IObservable<T> source, Func<T, CancellationToken, Task> onNext)
    {
        return source.Select(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Concat()
            .Subscribe();
    }

    public static IDisposable Subscribe<T>(
        this IObservable<T> source,
        Func<T, CancellationToken, Task> onNext,
        Action onCompleted)
    {
        return source.Select(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Concat()
            .Subscribe(_ => { }, onCompleted);
    }

    public static IDisposable Subscribe<T>(
        this IObservable<T> source,
        Func<T, CancellationToken, Task> onNext,
        Action<Exception> onError)
    {
        return source.Select(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Concat()
            .Subscribe(_ => { }, onError);
    }

    public static IDisposable Subscribe<T>(
        this IObservable<T> source,
        Func<T, CancellationToken, Task> onNext,
        Action<Exception> onError,
        Action onCompleted)
    {
        return source.Select(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Concat()
            .Subscribe(_ => { }, onError, onCompleted);
    }

    public static IDisposable SubscribeAsync<T>(this IObservable<T> source, Func<T, Task> onNext)
    {
        return source.SelectMany(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Subscribe();
    }

    public static IDisposable SubscribeAsync<T>(
        this IObservable<T> source,
        Func<T, Task> onNext,
        Action onCompleted)
    {
        return source.SelectMany(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Subscribe(_ => { }, onCompleted);
    }

    public static IDisposable SubscribeAsync<T>(
        this IObservable<T> source,
        Func<T, Task> onNext,
        Action<Exception> onError)
    {
        return source.SelectMany(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Subscribe(_ => { }, onError);
    }

    public static IDisposable SubscribeAsync<T>(
        this IObservable<T> source,
        Func<T, Task> onNext,
        Action<Exception> onError,
        Action onCompleted)
    {
        return source.SelectMany(arg => Observable.FromAsync(async _ => await onNext.Invoke(arg)))
            .Subscribe(_ => { }, onError, onCompleted);
    }

    public static IDisposable SubscribeAsync<T>(this IObservable<T> source, Func<T, CancellationToken, Task> onNext)
    {
        return source.SelectMany(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Subscribe();
    }

    public static IDisposable SubscribeAsync<T>(
        this IObservable<T> source,
        Func<T, CancellationToken, Task> onNext,
        Action onCompleted)
    {
        return source.SelectMany(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Subscribe(_ => { }, onCompleted);
    }

    public static IDisposable SubscribeAsync<T>(
        this IObservable<T> source,
        Func<T, CancellationToken, Task> onNext,
        Action<Exception> onError)
    {
        return source.SelectMany(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Subscribe(_ => { }, onError);
    }

    public static IDisposable SubscribeAsync<T>(
        this IObservable<T> source,
        Func<T, CancellationToken, Task> onNext,
        Action<Exception> onError,
        Action onCompleted)
    {
        return source.SelectMany(arg => Observable.FromAsync(async token => await onNext.Invoke(arg, token)))
            .Subscribe(_ => { }, onError, onCompleted);
    }
}
