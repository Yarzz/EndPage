using System.Collections.Generic;
using System.Linq;
using Core.Components;

namespace Core.Entities
{
    public abstract class Entity
    {
        public List<IEntityComponent> Components { get; set; }

        protected Entity(IEnumerable<IEntityComponent> components)
        {
            Components = components.ToList();
        }
    }
}