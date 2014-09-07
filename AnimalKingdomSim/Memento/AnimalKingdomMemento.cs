using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnimalKingdomSimulator.BoardState;
using AnimalKingdomSimulator.Observer;

namespace AnimalKingdomSimulator
{
    public class AnimalKingdomMemento : Memento.Memento
    {
        private WorldStatistics ws;
        private State state;
        private List<GridObject> occupants;

        public AnimalKingdomMemento(GridObject[,] occupant, WorldStatistics ws, State state, Subject subject)
        {
            occupants = new List<GridObject>();

            foreach (GridObject or in occupant)
            {
                if (or is Animal)
                {
                    Animal momento = ((Animal)or).clone();
                    subject.removeObserver(momento);
                    occupants.Add(momento);
                    continue;
                }
                if (or is Environments.Environment)
                {
                    Environments.Environment momento = ((Environments.Environment)or).clone();
                    occupants.Add(momento);
                    continue;
                }
            }
            
            this.state = state;
            this.ws = ws.clone();
        }

        public WorldStatistics WorldStatistics
        {
            get { return ws; }
        }

        public State State
        {
            get { return state; }
        }

        public List<GridObject> Occupants
        {
            get { return occupants; }
        }
    }
}
