using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Observer
{
    public interface Subject
    {
        void registerObserver(Observer sub);
        void removeObserver(Observer sub);
        void notifyObservers();
    }
}
