using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Observer
{
    public interface Observer
    {
        void update(int moveCount);
    }
}
