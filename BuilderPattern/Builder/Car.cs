
namespace BuilderPattern.Builder
{
    public class Car
    {
        public string EngineType { get; set; } = null!;
        public string Color { get; set; } = null!;
        // Optional properties
        public string? WheelsType { get; set; }
        public string? SoundSystem { get; set; }
        public string? Interior { get; set; } 
        public bool HasSunroof { get; set; }
        public bool HasGPS { get; set; }
        
        public override string ToString()
        {
            return "Final Car Configuration:\n" +
                   $"  - Engine: {EngineType}\n" +
                   $"  - Color: {Color}\n" +
                   $"  - Wheels: {(WheelsType ?? "Standard")}\n" +
                   $"  - Sound System: {(SoundSystem ?? "Standard")}\n" +
                   $"  - Interior: {(Interior ?? "Standard")}\n" +
                   $"  - Sunroof: {(HasSunroof ? "Yes" : "No")}\n" +
                   $"  - GPS: {(HasGPS ? "Yes" : "No")}";
        }
    }
}