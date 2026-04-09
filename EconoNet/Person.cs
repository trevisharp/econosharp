namespace Econonet;

public class Person
{
    public Guid ID { get; private init; } = Guid.NewGuid();
    public string? Tag { get; set; }
    public required int Age { get; set; }
    public required float Happiness { get; set; }
    public required float Money { get; set; }
    public required float Hedonism { get; set; }
    public required float Health { get; set; }

    public override string ToString()
        => $"Person({ID}, {Happiness:F}, {Health:F}, {Tag})";
}