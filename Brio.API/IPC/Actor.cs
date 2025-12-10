using Brio.API.Enums;
using Brio.API.Helpers;
using Brio.API.Interface;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;

namespace Brio.API;

public class SpawnActor(IDalamudPluginInterface pi) : FuncSubscriber<SpawnFlags, bool, bool, IGameObject>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(SpawnActor)}.V3";

    /// <inheritdoc cref="IActor.Spawn"/>
    public IGameObject Invoke()
        => base.Invoke(SpawnFlags.Default, false, false);

    /// <inheritdoc cref="IActor.Spawn"/>
    public IGameObject Invoke(bool spawnFrozen)
        => base.Invoke(SpawnFlags.Default, false, spawnFrozen);

    /// <inheritdoc cref="IActor.Spawn"/>
    public IGameObject Invoke(SpawnFlags spawnFlags, bool spawnFrozen)
        => base.Invoke(spawnFlags, false, spawnFrozen);

    public static FuncProvider<SpawnFlags, bool, bool, IGameObject> Provider(IDalamudPluginInterface pi, IActor api)
        => new(pi, Label, api.Spawn);
}

public class DespawnActor(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(DespawnActor)}.V3";

    /// <inheritdoc cref="IActor.Despawn"/>
    public new bool Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, bool> Provider(IDalamudPluginInterface pi, IActor api)
        => new(pi, Label, api.Despawn);
}

public class ActorExists(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(ActorExists)}.V3";

    /// <inheritdoc cref="IActor.Exists"/>
    public new bool Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, bool> Provider(IDalamudPluginInterface pi, IActor api)
        => new(pi, Label, api.Exists);
}

public class GetAllActors(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject[]?>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(GetAllActors)}.V3";

    /// <inheritdoc cref="IActor.Exists"/>
    public new IGameObject[]? Invoke()
        => base.Invoke();

    public static FuncProvider<IGameObject[]?> Provider(IDalamudPluginInterface pi, IActor api)
        => new(pi, Label, api.GetAllActors);
}
