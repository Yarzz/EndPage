using System.Numerics;
using Core.Components;

namespace Physics.Components
{
    public class Position : IEntityComponent
    {
        public Vector2 PositionVector { get; set; }

        public Position()
        {
            PositionVector = Vector2.Zero;
        }

        public Position(float x, float y)
        {
            PositionVector = new Vector2(x, y);
        }
    }
}
