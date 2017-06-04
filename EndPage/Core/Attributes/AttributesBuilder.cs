using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Systems;

namespace Core.Attributes
{
    public class AttributesBuilder : IEntityAttributesBuilder
    {
        public virtual List<IEntityAttribute> ConstructAttributesFromEntity(Entity entity, IEnumerable<GameSystem> systems)
        {
            var constructedAttributes = new List<IEntityAttribute>();
            foreach (var system in systems)
            {
                IEntityAttribute attribute;
                if (system.TryConstructAttribute(entity, out attribute))
                    constructedAttributes.Add(attribute);
            }
            return constructedAttributes;
        }
    }
}
