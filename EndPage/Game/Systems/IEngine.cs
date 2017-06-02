namespace Game.Systems
{
    public interface IEngine
    {
        void MainLoop();
        void UpdateSystems();
        void AddSystem(IGameSystem system);
    }
}
