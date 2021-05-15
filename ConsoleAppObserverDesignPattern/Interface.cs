using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppObserverDesignPattern
{
    public interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObservers();
    }
    public interface IObserver { 
        public void update();
    }
    public interface IWeatherData
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObservers();
    }
    public interface IDisplayElement { 
        public void display(); 
    }

}
