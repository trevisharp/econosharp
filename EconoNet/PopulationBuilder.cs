using Econonet.Behaviours;

namespace Econonet;

public class PopulationBuilder
{
    readonly Population population = new();

    public PopulationBuilder Add(IBehaviour behaviour)
    {
        population.Behaviours.Add(behaviour);
        return this;
    }

    public Population Build()
        => population;
}