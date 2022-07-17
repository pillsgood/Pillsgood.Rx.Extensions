using System.Reactive.Disposables;

namespace Pillsgood.Rx.Extensions;

public interface IDisposableWith
{
    CompositeDisposable CompositeDisposable { get; }
}
