using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Engine;

namespace Physics.Components
{
    public class MovementComponents : IComponentNode
    {
        public Position Position { get; set; }
        public Velocity Velocity { get; set; }
    }
}
