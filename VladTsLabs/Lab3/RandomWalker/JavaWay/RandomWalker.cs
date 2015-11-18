using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.JavaWay
{
    public class RandomWalker
    {
        protected Random randomizer;
        private List<IRandomWalkerObserver> observers;
        public int Position { get; protected set; }

        public RandomWalker()
        {
            randomizer = new Random();
            observers = new List<IRandomWalkerObserver>();
            Position = 0;
        }

        public virtual void MakeStep()
        {
            RandomWalkEvent.Directions direction = (randomizer.Next(100000) % 2 == 0)
                ? RandomWalkEvent.Directions.LEFT
                : RandomWalkEvent.Directions.RIGHT;

            Position += (int) direction;

            foreach (IRandomWalkerObserver observer in observers)
            {
                observer.Moved(new RandomWalkEvent(direction, this));
            }
        }

        public void AddObserver(IRandomWalkerObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IRandomWalkerObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
