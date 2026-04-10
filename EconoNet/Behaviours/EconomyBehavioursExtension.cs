namespace Econonet.Behaviours;

public static class EconomyBehavioursExtension
{
    public static EconomyBuilder AddDefaultInit(
        this EconomyBuilder builder,
        int population, float monetaryBase)
    {
        builder.Add(new DefaultInitBehaviour(population, monetaryBase));
        return builder;
    }
}