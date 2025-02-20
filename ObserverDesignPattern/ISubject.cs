using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    interface ISubject
    {
        void RegisterObserver(IObersver observer);
        void RemoveObserver(IObersver observer);
        void NotifyObservers(string news);
    }
}
