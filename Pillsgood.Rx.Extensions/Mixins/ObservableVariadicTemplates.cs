using System.Reactive.Linq;

// ReSharper disable once CheckNamespace
namespace System;

public static class ObservableVariadicMixins
{
    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Action<T1, T2> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2));
    }

    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Action<T1, T2> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2), onError);
    }

    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Action<T1, T2> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2), onComplete);
    }

    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Action<T1, T2> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2));
    }

    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2), onError);
    }

    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2), onComplete);
    }

    public static IDisposable Subscribe<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2));
    }

    public static IDisposable SubscribeAsync<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, TResult>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2));
    }

    public static IObservable<TResult> SelectMany<T1, T2, TResult>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2));
    }

    public static IObservable<TResult> SelectMany<T1, T2, TResult>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2));
    }

    public static IObservable<TResult> SelectMany<T1, T2, TResult>(
        this IObservable<(T1, T2)> source,
        Func<T1, T2, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2));
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Action<T1, T2, T3> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3));
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Action<T1, T2, T3> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Action<T1, T2, T3> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Action<T1, T2, T3> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3));
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, TResult>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, TResult>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, TResult>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, TResult>(
        this IObservable<(T1, T2, T3)> source,
        Func<T1, T2, T3, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Action<T1, T2, T3, T4> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Action<T1, T2, T3, T4> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Action<T1, T2, T3, T4> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Action<T1, T2, T3, T4> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, T4, TResult>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, TResult>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, TResult>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, TResult>(
        this IObservable<(T1, T2, T3, T4)> source,
        Func<T1, T2, T3, T4, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Action<T1, T2, T3, T4, T5> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Action<T1, T2, T3, T4, T5> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Action<T1, T2, T3, T4, T5> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Action<T1, T2, T3, T4, T5> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, T4, T5, TResult>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, TResult>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, TResult>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, TResult>(
        this IObservable<(T1, T2, T3, T4, T5)> source,
        Func<T1, T2, T3, T4, T5, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Action<T1, T2, T3, T4, T5, T6> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Action<T1, T2, T3, T4, T5, T6> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Action<T1, T2, T3, T4, T5, T6> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Action<T1, T2, T3, T4, T5, T6> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, T4, T5, T6, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6)> source,
        Func<T1, T2, T3, T4, T5, T6, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Action<T1, T2, T3, T4, T5, T6, T7> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Action<T1, T2, T3, T4, T5, T6, T7> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Action<T1, T2, T3, T4, T5, T6, T7> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Action<T1, T2, T3, T4, T5, T6, T7> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onError, onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10));
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext,
        Action<Exception> onError)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onError);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onComplete);
    }

    public static IDisposable Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.Subscribe(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onError, onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10));
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext,
        Action<Exception> onError)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onError);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onComplete);
    }

    public static IDisposable SubscribeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> onNext,
        Action<Exception> onError,
        Action onComplete)
    {
        return source.SubscribeAsync(t => onNext(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10), onError, onComplete);
    }

    public static IObservable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> selector)
    {
        return source.Select(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, IObservable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10));
    }

    public static IObservable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        this IObservable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, IEnumerable<TResult>> selector)
    {
        return source.SelectMany(t => selector.Invoke(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7, t.Item8, t.Item9, t.Item10));
    }
}