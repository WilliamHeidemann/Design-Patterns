using Facade;

var waterCalculator = new WaterCalcFacade();
Console.WriteLine("Should I drink water today?");
Console.WriteLine(waterCalculator.ShouldDrinkWaterToday() ? "Yes" : "No");