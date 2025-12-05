
namespace Brio.API.Enums;

[Flags]
public enum SpawnFlags : ulong
{
    None = 0,
    ReserveCompanionSlot = 1 << 1,
    CopyPosition = 1 << 2,
    IsProp = 1 << 4,
    IsEffect = 1 << 8,
    SetDefaultAppearance = 1 << 16,

    Prop = IsProp | SetDefaultAppearance | CopyPosition,
    Effect = IsEffect | SetDefaultAppearance | CopyPosition,
    Default = CopyPosition,
}
