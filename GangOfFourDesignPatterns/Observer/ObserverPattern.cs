using System;
using System.Runtime.CompilerServices;

namespace GangOfFourDesignPatterns.Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void Notify();
    }
    public interface IObserver
    {
        void Subscribe(ISubject subject);
        void Unsubscribe(ISubject subject);
        void Update(string state);
    }

    public class Subject : ISubject
    {
        List<IObserver> lstObservers = new List<IObserver>();
        private string ProductName { get; set; } = null!;
        private int ProductPrice { get; set; }
        private string State {get; set; } = null!;

        public Subject(string productName, int productPrice, string State)
        {
            this.ProductName = productName;
            this.ProductPrice = ProductPrice;
            this.State = State;
        }

        public string GetCurrentState()
        {
            return this.State;
        }

        public void SetState(string state)
        {
            this.State = state;
            Console.WriteLine("State of the product has been updated to : "+ state);
            Notify();
        }
        public void RegisterObserver(IObserver observer)
        {
            this.lstObservers.Add(observer);
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
        }

        public void UnregisterObserver(IObserver observer)
        {
            this.lstObservers.Remove(observer);
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
        }
        public void Notify()
        {
            Console.WriteLine("Product Name :" + ProductName + ", Product Price : " + ProductPrice + " is Now available. So, notifying all Registered users ");
            foreach (IObserver observer in lstObservers)
            {
                observer.Update(State);
            }
        }
    }

    public class Observer : IObserver
    {
       public string UserName { get; set; }
        public Observer(string username)
        {
            UserName = username;
        }
        public void Subscribe(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void Unsubscribe(ISubject subject)
        {
            subject.UnregisterObserver(this);
        }

        public void Update(string state)
        {
           Console.WriteLine("Hello " + UserName + ", Product is now " + state + " on Amazon");
        }
    }
}