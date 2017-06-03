using System;
using System.Collections.Generic;
using Core.Engine;
using Core.Systems;
using Physics.Components;

namespace Physics.Systems
{
    public class Movement : IGameSystem
    {
        public IEnumerable<MovementComponents> Nodes { get; set; }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
