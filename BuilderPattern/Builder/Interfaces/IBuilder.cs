
namespace BuilderPattern.Builder.Interfaces
{
    public interface IBuilder
    {
        void SetEngine(string engineType);
        void SetColor(string color);
        void SetWheels(string wheelsType);
        void SetSoundSystem(string soundSystem);
        void SetInterior(string interior);
        void SetSunroof(bool hasSunroof);
        void SetGPS(bool hasGPS);
    }
}