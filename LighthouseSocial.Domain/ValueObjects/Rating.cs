public record Rating
{
    public int Value { get; }

    private Rating(int value)
    {
        Value = value;
    }

    public static Rating FromValue(int value)
    {
        if (value < 1 || value > 10)
            throw new ArgumentOutOfRangeException(nameof(value));

        return new Rating(value);
    }
}
