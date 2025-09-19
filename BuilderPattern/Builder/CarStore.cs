

using BuilderPattern.Builder.Interfaces;

namespace BuilderPattern.Builder
{
    public class CarStore
    {
        private readonly IBuilder _builder;

        public CarStore(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildStandardCar()
        {
            if (_builder == null) throw new InvalidOperationException("Builder must be set before building a car.");
            _builder.SetEngine("Standard");
            _builder.SetColor("White");
            _builder.SetWheels("16-inch Standard Wheels");
        }

        public void BuildPremiumCar()
        {
            if (_builder == null) throw new InvalidOperationException("Builder must be set before building a car.");
            _builder.SetEngine("V8 Premium");
            _builder.SetColor("Metallic Red");
            _builder.SetWheels("20-inch Sport Wheels");
            _builder.SetSoundSystem("Bose Premium Audio");
            _builder.SetInterior("Black Leather");
            _builder.SetSunroof(true);
            _builder.SetGPS(true);
        }
    }
}