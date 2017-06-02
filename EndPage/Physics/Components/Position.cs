using System.Numerics;
using Game.Components;

namespace Physics.Components
{
    public class Position : IGameComponent
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
