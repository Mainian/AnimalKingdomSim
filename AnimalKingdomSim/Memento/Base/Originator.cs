using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Memento
{
    public interface Originator
    {
        void SetMemento(Memento memento);
        Memento CreateMemento();
    }
}
