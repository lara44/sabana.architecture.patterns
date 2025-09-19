
using BuilderPattern.Builder;

var builder = new CarBuilder();
var carStore = new CarStore(builder);

Console.WriteLine("Building a Standard Car:");
carStore.BuildStandardCar();
Console.WriteLine(builder.GetCar().ToString());

builder.Reset();

Console.WriteLine("\nBuilding a Premium Car:");
carStore.BuildPremiumCar();
Console.WriteLine(builder.GetCar().ToString());

builder.Reset();

Console.WriteLine("\nBuilding a Custom Car (without a Director):");
builder.SetEngine("Hybrid");
builder.SetColor("Blue");
builder.SetSunroof(true);
builder.SetGPS(true);
Console.WriteLine(builder.GetCar().ToString());