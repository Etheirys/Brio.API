using Dalamud.Game.ClientState.Objects.Types;

namespace Brio.API.Interface;

public interface IAnimation
{
    /// <summary>
    /// Sets the animation for the specified actor.
    /// </summary>
    /// <param name="gameObject">The game object to apply the animation to.</param>
    /// <param name="animationID">The ID of the animation to play.</param>
    /// <param name="playOnLoad">Whether to start playing the animation immediately when loaded.</param>
    /// <returns>true if the animation was successfully set; otherwise, false.</returns>
    public bool SetActorAnimation(IGameObject gameObject, string animationID, bool playOnLoad);

    /// <summary>
    /// Sets the animation playback speed for the specified actor.
    /// </summary>
    /// <param name="gameObject">The game object to modify the animation speed for.</param>
    /// <param name="speed">The animation speed multiplier (e.g., 1.0 for normal speed, 0.5 for half speed, 2.0 for double speed).</param>
    /// <returns>true if the speed was successfully set; otherwise, false.</returns>
    public bool SetActorSpeed(IGameObject gameObject, float speed);
    
    /// <summary>
    /// Gets the current animation playback speed for the specified actor.
    /// </summary>
    /// <param name="gameObject">The game object to retrieve the animation speed from.</param>
    /// <returns>The current animation speed multiplier.</returns>
    public float GetActorSpeed(IGameObject gameObject);

    /// <summary>
    /// Freezes the animation of the specified actor
    /// </summary>
    /// <param name="gameObject">The game object to freeze.</param>
    /// <returns>true if the actor was successfully frozen; otherwise, false.</returns>
    public bool FreezeActor(IGameObject gameObject);
    
    /// <summary>
    /// Unfreezes the animation of the specified actor, resuming playback.
    /// </summary>
    /// <param name="gameObject">The game object to unfreeze.</param>
    /// <returns>true if the actor was successfully unfrozen; otherwise, false.</returns>
    public bool UnFreezeActor(IGameObject gameObject);
}
