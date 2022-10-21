using System.Reactive.Disposables;

namespace Pillsgood.Rx.Extensions;

public interface IDisposableWith : IDisposable
{
    CompositeDisposable CompositeDisposable { get; }
}

public interface IAsyncDisposableWith : IAsyncDisposable
{
    CompositeAsyncDisposable CompositeAsyncDisposable { get; }
}
