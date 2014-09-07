using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Memento
{
    public abstract class Caretaker<val> where val : Caretaker<val>, new()
    {
        private static val instance;

        public static val Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new val();
                }
                return instance;
            }
        }

        private Memento memento;

        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
