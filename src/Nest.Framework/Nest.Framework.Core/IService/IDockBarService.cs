namespace Nest.Framework.Core
{
    public interface IDockBarService
    {
        void AddDockBar(DockBar dockBar);

        DockBar IsNowActive();

        void IsActive(DockBar dockBar);

        void AddDockBar(string dockBarName, NewForm dockBar, DockState dockState);
    }
}
