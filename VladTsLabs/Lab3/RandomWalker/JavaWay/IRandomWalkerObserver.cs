using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.RandomWalker.JavaWay
{
    public interface IRandomWalkerObserver
    {
        void Moved(RandomWalkEvent evt);
    }
}
