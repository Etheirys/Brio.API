
namespace Brio.API.Interface;

public interface IState
{
    /// <summary>
    /// The API version is staggered in two parts.
    /// The major/Breaking version only increments if there are changes breaking backwards compatibility.
    /// The minor/Feature version increments any time there is something added and resets when Breaking is incremented.
    /// </summary>
    public (int Breaking, int Feature) ApiVersion { get; }

    /// <summary>
    /// Gets a value indicating whether the API is currently available and ready for use.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if the API is available; otherwise, <see langword="false"/>.
    /// </value>
    public bool IsAvailable { get; }

    /// <summary>
    /// Checks if a GPose session is valid.
    /// </summary>
    public bool IsValidGPoseSession { get; }
}
