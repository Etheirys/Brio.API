using Brio.API.Interface;

namespace Brio.API;

public interface IBrioAPI
{
    public bool Valid { get; }


    public IState State { get; }

    public IActor Actor { get; }

    public IEnvironment Environment { get; }

    public IAnimation Animation { get; }

}
