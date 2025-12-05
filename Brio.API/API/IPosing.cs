using Dalamud.Game.ClientState.Objects.Types;
using System.Numerics;

namespace Brio.API.Interface;

public interface IPosing
{
    /// <summary>
    /// Sets the model transform (position, rotation, and/or scale) for a game object.
    /// </summary>
    /// <param name="gameObject">The game object to transform.</param>
    /// <param name="position">The position to set, or null to keep current position.</param>
    /// <param name="rotation">The rotation to set, or null to keep current rotation.</param>
    /// <param name="scale">The scale to set, or null to keep current scale.</param>
    /// <param name="relativeMode">If true, applies the transform relative to the current transform; otherwise applies absolute values.</param>
    /// <returns>True if the transform was successfully applied; otherwise, false.</returns>
    public bool SetModelTransform(IGameObject gameObject, Vector3? position, Quaternion? rotation, Vector3? scale, bool relativeMode);

    /// <summary>
    /// Gets the current model transform (position, rotation, and scale) of a game object.
    /// </summary>
    /// <param name="gameObject">The game object to query.</param>
    /// <returns>A tuple containing the position, rotation, and scale. Any component may be null if not available.</returns>
    public (Vector3?, Quaternion?, Vector3?) GetModelTransform(IGameObject gameObject);

    /// <summary>
    /// Resets the model transform of a game object to its default state.
    /// </summary>
    /// <param name="gameObject">The game object to reset.</param>
    /// <returns>True if the transform was successfully reset; otherwise, false.</returns>
    public bool ResetModelTransform(IGameObject gameObject);

    /// <summary>
    /// Loads a pose from a file and applies it to a game object.
    /// </summary>
    /// <param name="gameObject">The game object to apply the pose to.</param>
    /// <param name="filename">The path to the pose file.</param>
    /// <returns>True if the pose was successfully loaded and applied; otherwise, false.</returns>
    public bool LoadPoseFromFile(IGameObject gameObject, string filename);

    /// <summary>
    /// Loads a pose from a JSON string and applies it to a game object.
    /// </summary>
    /// <param name="gameObject">The game object to apply the pose to.</param>
    /// <param name="isLegacyCMToolPose">If true, interprets the JSON as a legacy CMTool pose format; otherwise uses the standard Brio .pose format.</param>
    /// <param name="filename">The JSON string containing the pose data.</param>
    /// <returns>True if the pose was successfully loaded and applied; otherwise, false.</returns>
    public bool LoadPoseFromJson(IGameObject gameObject, bool isLegacyCMToolPose, string filename);

    /// <summary>
    /// Gets the current pose of a game object as a JSON string.
    /// </summary>
    /// <param name="gameObject">The game object to get the pose from.</param>
    /// <returns>A JSON string representing the pose, or null if the pose could not be retrieved.</returns>
    public string? GetPoseasJson(IGameObject gameObject);

    /// <summary>
    /// Resets the pose of a game object to its default state.
    /// </summary>
    /// <param name="gameObject">The game object to reset.</param>
    /// <param name="clearHistory">If true, clears the pose history; otherwise only resets the current pose.</param>
    /// <returns>True if the pose was successfully reset; otherwise, false.</returns>
    public bool ResetPose(IGameObject gameObject, bool clearHistory);
}
