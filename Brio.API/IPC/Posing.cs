using Brio.API.Helpers;
using Brio.API.Interface;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;
using System.Numerics;

namespace Brio.API.IPC;

public class SetModelTransform(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, Vector3?, Quaternion?, Vector3?, bool, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(SetModelTransform)}.V3";

    /// <inheritdoc cref="IPosing.SetModelTransform"/>
    public new bool Invoke(IGameObject gameObject, Vector3? position, Quaternion? rotation, Vector3? scale, bool relativeMode = false)
        => base.Invoke(gameObject, position, rotation, scale, relativeMode);

    public static FuncProvider<IGameObject, Vector3?, Quaternion?, Vector3?, bool, bool> Provider(IDalamudPluginInterface pi, IPosing api)
        => new(pi, Label, api.SetModelTransform);
}

public class GetModelTransform(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, (Vector3?, Quaternion?, Vector3?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(SetModelTransform)}.V3";

    /// <inheritdoc cref="IPosing.GetModelTransform"/>
    public new (Vector3?, Quaternion?, Vector3?) Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, (Vector3?, Quaternion?, Vector3?)> Provider(IDalamudPluginInterface pi, IPosing api)
        => new(pi, Label, api.GetModelTransform);
}

public class ResetModelTransform(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(ResetModelTransform)}.V3";

    /// <inheritdoc cref="IPosing.ResetModelTransform"/>
    public new bool Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, bool> Provider(IDalamudPluginInterface pi, IPosing api)
        => new(pi, Label, api.ResetModelTransform);
}

public class LoadPoseFromFile(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, string, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(LoadPoseFromFile)}.V3";

    /// <inheritdoc cref="IPosing.LoadPoseFromFile"/>
    public new bool Invoke(IGameObject gameObject, string filename)
        => base.Invoke(gameObject, filename);

    public static FuncProvider<IGameObject, string, bool> Provider(IDalamudPluginInterface pi, IPosing api)
        => new(pi, Label, api.LoadPoseFromFile);
}

public class LoadPoseFromJson(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, bool, string, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(LoadPoseFromJson)}.V3";

    /// <inheritdoc cref="IPosing.LoadPoseFromJson"/>
    public bool Invoke(IGameObject gameObject, string filename, bool isLegacyCMToolPose = false)
        => base.Invoke(gameObject, isLegacyCMToolPose, filename);

    public static FuncProvider<IGameObject, bool, string, bool> Provider(IDalamudPluginInterface pi, IPosing api)
        => new(pi, Label, api.LoadPoseFromJson);
}

public class GetPoseasJson(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, string?>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(GetPoseasJson)}.V3";

    /// <inheritdoc cref="IPosing.GetPoseasJson"/>
    public new string? Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, string?> Provider(IDalamudPluginInterface pi, IPosing api)
        => new(pi, Label, api.GetPoseasJson);
}

public class ResetPose(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, bool, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(ResetPose)}.V3";

    /// <inheritdoc cref="IPosing.ResetPose"/>
    public new bool Invoke(IGameObject gameObject, bool clearHistory = true)
        => base.Invoke(gameObject, clearHistory);

    public static FuncProvider<IGameObject, bool, bool> Provider(IDalamudPluginInterface pi, IPosing api)
        => new(pi, Label, api.ResetPose);
}
