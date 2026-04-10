namespace Econonet.Behaviours;

using Utils;

public class DefaultInitBehaviour(int population, float monetaryBase) : IBehaviour
{
    public bool Tick(Economy eco)
    {
        var gen = new NormalGenerator(
            Random.Shared,
            .5f, .2f, 0f, 1f
        );

        var totalMoney = 0f;
        for (int i = 0; i < population; i++)
        {
            var money = gen.Next();
            totalMoney += money;

            eco.Population.Add(new Person {
                Age = 18,
                Happiness = gen.Next(),
                Health = gen.Next(),
                Hedonism = gen.Next(),
                Money = money
            });
        }

        var adjust = monetaryBase / totalMoney;
        foreach (var person in eco.Population)
            person.Money *= adjust;

        return false;
    }
}