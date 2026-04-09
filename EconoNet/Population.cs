namespace Econonet;

using Behaviours;

public class Population
{
    public int TickCount { get; private set; } = 0;
    public List<Person> People { get; private init; } = [];
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
    
    public static PopulationBuilder Create()
        => new();
}