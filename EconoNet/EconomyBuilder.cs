using Econonet.Behaviours;

namespace Econonet;

public class EconomyBuilder
{
    readonly Economy economy = new();

    public EconomyBuilder Add(IBehaviour behaviour)
    {
        economy.Behaviours.Add(behaviour);
        return this;
    }

    public Economy Build()
        => economy;
}