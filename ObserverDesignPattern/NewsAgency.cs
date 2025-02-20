using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class NewsAgency:ISubject
    {
        private List<IObersver> observers;
        private string news;
        public NewsAgency()
        {
            observers = new List<IObersver>();
        }
        public void RegisterObserver(IObersver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObersver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers(string news)
        {
            foreach (var observer in observers)
            {
                observer.Update(news);
            }
        }
        
    }
}
