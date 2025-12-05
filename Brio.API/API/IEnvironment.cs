
namespace Brio.API.Interface;

public interface IEnvironment
{
    /// <summary>
    /// Freezes physics simulations in the environment.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if physics was successfully frozen; otherwise, <see langword="false"/>.
    /// </returns>
    public bool FreezePhysics();

    /// <summary>
    /// Unfreezes physics simulations in the environment, restoring normal physics behavior.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if physics was successfully unfrozen; otherwise, <see langword="false"/>.
    /// </returns>
    public bool UnFreezePhysics();
}
