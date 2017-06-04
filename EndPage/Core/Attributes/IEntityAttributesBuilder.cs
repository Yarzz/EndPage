using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Systems;

namespace Core.Attributes
{
    public interface IEntityAttributesBuilder
    {
        List<IEntityAttribute> ConstructAttributesFromEntity(Entity entity, IEnumerable<GameSystem> systems);
    }
}
