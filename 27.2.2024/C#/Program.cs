using System;
using System.Threading.Tasks.Dataflow;
namespace Project
{
    public delegate void TemperatureChangeHandler(int newtemperature);
    public class TemperatureSensor
    {
        public event TemperatureChangeHandler TemperatureChanged;
        private int currentTemperature;
        public TemperatureSensor()
        {
            currentTemperature = 20;
        }
        public void UpdateTemperature(int new_temperature)
        {
            if (new_temperature != currentTemperature)
            {
                currentTemperature = new_temperature;
                TemperatureChanged?.Invoke(currentTemperature);
            }
        }
    }

    public class TemperatureDisplay
    {
        public static void HandleTemperatureChange(int newTemperature)
        {
            Console.WriteLine($"Temperature changed to {newTemperature} degrees.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            TemperatureSensor temperatureSensor = new TemperatureSensor();
            TemperatureDisplay temperatureDisplay = new TemperatureDisplay();
            temperatureSensor.TemperatureChanged += TemperatureDisplay.HandleTemperatureChange;
            temperatureSensor.UpdateTemperature(22);
            temperatureSensor.UpdateTemperature(21);
        }
    }
}