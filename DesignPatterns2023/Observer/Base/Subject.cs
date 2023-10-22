using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Observer.Base
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();
        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver(object arg)
        {
            _observers.ForEach((observer) => observer.Notify(arg));
        }
    }
}
