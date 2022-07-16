using System.Reactive;

namespace Pillsgood.Rx.Extensions.Operators;

internal abstract class OperatorObserverBase<TSource, TResult> : ObserverBase<TSource>
{
    protected readonly IObserver<TResult> Observer;

    protected OperatorObserverBase(IObserver<TResult> observer)
    {
        Observer = observer;
    }
}
