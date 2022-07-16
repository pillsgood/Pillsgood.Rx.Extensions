using System.Reactive;

namespace Pillsgood.Rx.Extensions.Operators;

internal class PairwiseObservable<T, TR> : ObservableBase<TR>
{
    private readonly IObservable<T> _source;
    private readonly Func<Pair<T>, TR> _selector;

    public PairwiseObservable(IObservable<T> source, Func<Pair<T>, TR> selector)
    {
        _source = source;
        _selector = selector;
    }

    protected override IDisposable SubscribeCore(IObserver<TR> observer)
    {
        return _source.Subscribe(new Pairwise(this, observer));
    }

    private class Pairwise : OperatorObserverBase<T, TR>
    {
        private readonly PairwiseObservable<T, TR> _parent;
        private T _previous = default!;
        private bool _isFirst = true;

        public Pairwise(PairwiseObservable<T, TR> parent, IObserver<TR> observer) : base(observer)
        {
            _parent = parent;
        }

        protected override void OnNextCore(T value)
        {
            if (_isFirst)
            {
                _isFirst = false;
                _previous = value;
                return;
            }

            TR v;
            try
            {
                v = _parent._selector(new Pair<T>(_previous, value));
                _previous = value;
            }
            catch (Exception e)
            {
                try
                {
                    Observer.OnError(e);
                }
                finally
                {
                    Dispose();
                }

                return;
            }

            Observer.OnNext(v);
        }

        protected override void OnErrorCore(Exception error)
        {
            try
            {
                Observer.OnError(error);
            }
            finally
            {
                Dispose();
            }
        }

        protected override void OnCompletedCore()
        {
            try
            {
                Observer.OnCompleted();
            }
            finally
            {
                Dispose();
            }
        }
    }
}

internal class PairwiseObservable<T> : ObservableBase<Pair<T>>
{
    private readonly IObservable<T> _source;

    public PairwiseObservable(IObservable<T> source)
    {
        _source = source;
    }

    protected override IDisposable SubscribeCore(IObserver<Pair<T>> observer)
    {
        return _source.Subscribe(new Pairwise(observer));
    }

    private class Pairwise : OperatorObserverBase<T, Pair<T>>
    {
        private T _previous = default!;
        private bool _isFirst = true;

        public Pairwise(IObserver<Pair<T>> observer) : base(observer)
        {
        }


        protected override void OnNextCore(T value)
        {
            if (_isFirst)
            {
                _isFirst = false;
                _previous = value;
                return;
            }

            var pair = new Pair<T>(_previous, value);
            _previous = value;
            Observer.OnNext(pair);
        }


        protected override void OnErrorCore(Exception error)
        {
            try
            {
                Observer.OnError(error);
            }
            finally
            {
                Dispose();
            }
        }


        protected override void OnCompletedCore()
        {
            try
            {
                Observer.OnCompleted();
            }
            finally
            {
                Dispose();
            }
        }
    }
}
