namespace Econonet;

using Behaviours;

public class Economy
{
    public int TickCount { get; private set; } = 0;
    public List<Person> Population { get; private init; } = [];
    public List<IBehaviour> Behaviours { get; private init; } = [];

    public void Tick()
    {
        for (int i = 0; i < Behaviours.Count; i++)
        {
            var behaviour = Behaviours[i];

            var keep = behaviour.Tick(this);
            if (keep)
                continue;
            
            Behaviours.RemoveAt(i);
            i--;
        }
        TickCount++;
    }
    
    public static EconomyBuilder Create()
        => new();
}