﻿namespace ObserverGenericVariant
{
    interface ISubject<T>
    {
        void Attach(IObserver<T> observer);
        void Detach(IObserver<T> observer);
        void NotifyAll();

    }
}
