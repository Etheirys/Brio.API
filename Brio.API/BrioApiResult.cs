
namespace Brio.API;

/// <summary>
/// The Result code returned
/// </summary>
public enum BrioApiResult
{
    Success = 0,

    IsNotInGPose = 1,

    IsApplyingMCDF = 7,
    FileMissing = 9,

    UnknownError = 255
}
