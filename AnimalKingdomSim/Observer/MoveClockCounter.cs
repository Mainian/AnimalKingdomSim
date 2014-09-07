using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace AnimalKingdomSimulator.Observer
{
    public delegate void Start(int waitDuration, out int threadId);

    public class MoveClockCounter : Subject
    {
        int m_moveCount;
        List<Observer> m_observers;

        private volatile bool _requestStop = false;

        public MoveClockCounter(int waitDuration)
        {
            m_moveCount = 0;
            m_observers = new List<Observer>();
            this.waitDuration = waitDuration;
        }

        public void registerObserver(Observer sub)
        {
            m_observers.Add(sub);
        }
        public void removeObserver(Observer sub)
        {
            m_observers.Remove(sub);
        }
        public void notifyObservers()
        {
            for (int i = 0; i < m_observers.Count; i++)
            {
                m_observers[i].update(m_moveCount);
            }
        }

        public int MoveCount
        {
            get
            {
                return m_moveCount;
            }
        }

        public List<Observer> Observers
        {
            get
            {
                return m_observers;
            }
        }

        public int waitDuration
        {
            set;
            get;
        }

        public void Start()
        {
            _requestStop = false;
            while (!_requestStop)
            {
                Thread.Sleep(waitDuration);
                m_moveCount++;
                notifyObservers();
            }
        }

        public void requestStop()
        {
            _requestStop = true;
        }
    }
}
