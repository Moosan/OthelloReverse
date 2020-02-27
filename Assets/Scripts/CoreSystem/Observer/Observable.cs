using System.Collections;
using System.Collections.Generic;
namespace CoreSystem.Observer
{
    public class Observable
    {
        readonly List<IObserver> observers = new List<IObserver>();
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        protected void Update()
        {
            NorifyObservers();
        }

        void NorifyObservers()
        {
            observers.ForEach(observer => observer.OnNext(this));
        }
    }
}