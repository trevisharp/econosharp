namespace Econonet.Utils;

public class NormalGenerator(
    Random rand,
    float averageValue,
    float stddev = 1f,
    float minValue = float.MinValue,
    float maxValue = float.MaxValue
)
{
    float? nextValue = null;

    public float Next()
    {
        if (!nextValue.HasValue)
            return GenerateNext();

        var value = nextValue.Value;
        nextValue = null;
        return value;    
    }

    float GenerateNext()
    {
        var u1 = rand.NextSingle();
        var u2 = rand.NextSingle();
        
        var z1 = MathF.Sqrt(-2 * MathF.Log(u1)) * MathF.Cos(MathF.Tau * u2);
        var z2 = MathF.Sqrt(-2 * MathF.Log(u1)) * MathF.Sin(MathF.Tau * u2);

        var v1 = z1 * stddev + averageValue;
        var v2 = z2 * stddev + averageValue;
        
        v1 = float.Clamp(v1, minValue, maxValue);
        v2 = float.Clamp(v2, minValue, maxValue);

        nextValue = v2;
        return v1;
    }
}