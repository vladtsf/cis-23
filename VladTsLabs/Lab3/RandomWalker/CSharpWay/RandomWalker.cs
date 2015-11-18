using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.CSharpWay
{
    public delegate void StepMade(StepEventArgs e);

    public class RandomWalker : JavaWay.RandomWalker
    {
        public event StepMade OnStepMade;

        public override void MakeStep()
        {
            StepEventArgs.Directions direction = (randomizer.Next(1000) % 2 == 0)
                ? StepEventArgs.Directions.LEFT
                : StepEventArgs.Directions.RIGHT;

            Position += (int) direction;

            if (OnStepMade != null)
            {
                OnStepMade(new StepEventArgs(direction, this));
            }
        }
    }
}
