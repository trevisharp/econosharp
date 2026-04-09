namespace Econonet;

public class Person
{
    public Guid ID { get; init; } = Guid.NewGuid();
    public required float Happiness { get; set; }
    public required float Money { get; set; }
    public required float Hedonism { get; set; }
    public required float Health { get; set; }
}