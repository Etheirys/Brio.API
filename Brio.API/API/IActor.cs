using Brio.API.Enums;
using Dalamud.Game.ClientState.Objects.Types;

namespace Brio.API.Interface;

public interface IActor
{
    /// <summary>
    /// Spawns a new game actor with the specified configuration.
    /// </summary>
    /// <param name="spawnFlags">Flags that control the spawning behavior of the actor.</param>
    /// <param name="selectInHierarchy">If <see langword="true"/>, the spawned actor will be selected in the hierarchy; otherwise, <see langword="false"/>.</param>
    /// <param name="spawnFrozen">If <see langword="true"/>, the actor will spawn with frozen physics; otherwise, <see langword="false"/>.</param>
    /// <returns>The spawned <see cref="IGameObject"/> instance.</returns>
    public IGameObject? Spawn(SpawnFlags spawnFlags, bool selectInHierarchy, bool spawnFrozen);

    /// <summary>
    /// Despawns the specified game object, removing it from the game world.
    /// </summary>
    /// <param name="gameObject">The game object to despawn.</param>
    /// <returns>
    /// <see langword="true"/> if the game object was successfully despawned; otherwise, <see langword="false"/>.
    /// </returns>
    public bool Despawn(IGameObject gameObject);

    /// <summary>
    /// Checks whether the specified game object currently exists in the game world.
    /// </summary>
    /// <param name="gameObject">The game object to check for existence.</param>
    /// <returns>
    /// <see langword="true"/> if the game object exists; otherwise, <see langword="false"/>.
    /// </returns>
    public bool Exists(IGameObject gameObject);

    /// <summary>
    /// Gets all actors currently present in the game world.
    /// </summary>
    /// <returns>
    /// An array of <see cref="IGameObject"/> instances representing all actors, or <see langword="null"/> if no actors are available.
    /// </returns>
    public IGameObject[]? GetAllActors();

    /// <summary>
    /// Loads an MCDF file into the actor.
    /// </summary>
    BrioApiResult LoadMCDF(IGameObject gameObject, string path);

    /// <summary>
    /// Saves the actor’s data to an MCDF file.
    /// </summary>
    BrioApiResult SaveMCDF(IGameObject gameObject, string path);
}
