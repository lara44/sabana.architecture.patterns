using BuilderPattern.Builder.Interfaces;

namespace BuilderPattern.Builder
{
   public class CarBuilder : IBuilder
    {
        private Car _car;
        public CarBuilder()
        {
            _car = new Car();
        }
        public void Reset() => _car = new Car();
        public void SetEngine(string engineType) => _car.EngineType = engineType;
        public void SetColor(string color) => _car.Color = color;
        public void SetWheels(string wheelsType) => _car.WheelsType = wheelsType;
        public void SetSoundSystem(string soundSystem) => _car.SoundSystem = soundSystem;
        public void SetInterior(string interior) => _car.Interior = interior;
        public void SetSunroof(bool hasSunroof) => _car.HasSunroof = hasSunroof;
        public void SetGPS(bool hasGPS) => _car.HasGPS = hasGPS;

        public Car GetCar()
        {
            var car = _car;
            Reset();
            return car;
        }
    }
}