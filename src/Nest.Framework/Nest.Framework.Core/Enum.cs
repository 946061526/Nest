public enum ConnectionType : int
{
    SqlServer = 1,
    Oracle = 2,
    OleDb = 3,
    Odbc = 4,
    MySQL = 5
}
/// <summary>
/// Amount：等于
/// GreaterThan：大于
/// GreaterOrEquals：大于等于
/// LessThan：小于
/// LessOrEquals：小于等于
/// NotEquals：不等于
/// </summary>
public enum Comparison
{
    Amount,         //=
    GreaterThan,    //>
    GreaterOrEquals, //>=
    LessThan,      //<
    LessOrEquals, //<=
    NotEquals     //<>
}
public enum DockState : int
{
    Unknown = 0,
    Float = 1,
    DockTopAutoHide = 2,
    DockLeftAutoHide = 3,
    DockBottomAutoHide = 4,
    DockRightAutoHide = 5,
    Document = 6,
    DockTop = 7,
    DockLeft = 8,
    DockBottom = 9,
    DockRight = 10,
    Hidden = 11
}
