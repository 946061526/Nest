namespace Nest.Framework.Core
{
    public interface IDockBarService
    {
        void AddDockBar(DockBar dockBar);

        DockBar NowActiveForm();

        void ActivateDockbar(DockBar dockBar);

        void AddDockBar(string dockBarName, NewForm dockBar, DockState dockState);
    }
}
