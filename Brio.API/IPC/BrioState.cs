using Brio.API.Helpers;
using Brio.API.Interface;
using Dalamud.Plugin;

namespace Brio.API.IPC;

/// <inheritdoc cref="IState.ApiVersion"/>
public class ApiVersion(IDalamudPluginInterface pi) : FuncSubscriber<(int Breaking, int Feature)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(ApiVersion)}";

    /// <inheritdoc cref="IState.ApiVersion"/>
    public new (int Breaking, int Feature) Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<(int Breaking, int Feature)> Provider(IDalamudPluginInterface pi, IState api)
        => new(pi, Label, () => api.ApiVersion);
}

/// <inheritdoc cref="IState.IsAvailable"/>
public class IsAvailable(IDalamudPluginInterface pi) : FuncSubscriber<bool>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Brio.{nameof(IsAvailable)}";

    /// <inheritdoc cref="IState.IsAvailable"/>
    public new bool Invoke()
        => base.Invoke();

    /// <summary> Create a provider. </summary>
    public static FuncProvider<bool> Provider(IDalamudPluginInterface pi, IState api)
        => new(pi, Label, () => api.IsAvailable);
}
