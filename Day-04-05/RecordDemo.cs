namespace Day04
{
    // Normal class (reference type)
    public class TempClass
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public TempClass(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    // Record (immutable reference type, value-based equality)
    public record Temp
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }

    // Struct (value type)
    public struct TempStruct
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
