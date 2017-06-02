using System.Collections.Generic;
using System.Linq;
using Game.Components;

namespace Game.Entities
{
    public abstract class Entity
    {
        public List<IGameComponent> Components { get; set; }
        protected Entity(IEnumerable<IGameComponent> components)
        {
            Components = components.ToList();
        }

        public virtual void Update()
        {
            
        }
    }
}