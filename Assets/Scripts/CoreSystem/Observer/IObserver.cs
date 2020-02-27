namespace CoreSystem.Observer
{
    public interface IObserver
    {
        void OnNext(Observable observable);
    }
}