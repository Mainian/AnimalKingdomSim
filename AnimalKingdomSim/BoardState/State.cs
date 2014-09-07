using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.BoardState
{
    public interface State
    {
        void GenerateWorld();
        void Start();
        void Pause();
        void Save();
        void Load();
    }
}
