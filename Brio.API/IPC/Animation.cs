using Brio.API.Interface;
using Brio.API.Helpers;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;

namespace Brio.API.IPC;

public class SetActorSpeed(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, float, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(SetActorSpeed)}.V3";

    /// <inheritdoc cref="IAnimation.SetActorSpeed"/>
    public new bool Invoke(IGameObject gameObject, float speed)
        => base.Invoke(gameObject, speed);

    public static FuncProvider<IGameObject, float, bool> Provider(IDalamudPluginInterface pi, IAnimation api)
        => new(pi, Label, api.SetActorSpeed);
}

public class GetActorSpeed(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, float>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(GetActorSpeed)}.V3";

    /// <inheritdoc cref="IAnimation.GetActorSpeed"/>
    public new float Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, float> Provider(IDalamudPluginInterface pi, IAnimation api)
        => new(pi, Label, api.GetActorSpeed);
}

public class FreezeActor(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(FreezeActor)}.V3";

    /// <inheritdoc cref="IAnimation.FreezeActor"/>
    public new bool Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, bool> Provider(IDalamudPluginInterface pi, IAnimation api)
        => new(pi, Label, api.FreezeActor);
}

public class UnFreezeActor(IDalamudPluginInterface pi) : FuncSubscriber<IGameObject, bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(UnFreezeActor)}.V3";

    /// <inheritdoc cref="IAnimation.UnFreezeActor"/>
    public new bool Invoke(IGameObject gameObject)
        => base.Invoke(gameObject);

    public static FuncProvider<IGameObject, bool> Provider(IDalamudPluginInterface pi, IAnimation api)
        => new(pi, Label, api.UnFreezeActor);
}
