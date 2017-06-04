using System;
using System.Collections.Generic;
using Core.Engine;
using Core.Systems;
using Physics.Components;

namespace Physics.Systems
{
    public class Movement : GameSystem
    {
        public IEnumerable<MovementNode> Nodes { get; set; }

        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }

        public virtual void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
