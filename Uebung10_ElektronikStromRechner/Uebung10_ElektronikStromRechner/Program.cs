using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung10_ElektronikStromRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double voltage, current, resistance1, temperature, voltageDifference, voltageCalculator, resistanceNeeded;
            bool overTemperature, overCurrent, overVoltage;
            Console.Write("Geben sie die Spannung in Volt ein: ");
            voltage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben sie den Widerstand in Ohm ein: ");
            resistance1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben sie die Temperatur in °C ein: ");
            temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben sie die Spannung der LED ein: ");
            voltageDifference = Convert.ToDouble(Console.ReadLine());

            current = voltage / resistance1;
            voltageCalculator = voltage - voltageDifference;
            resistanceNeeded = voltageCalculator / current;

            Console.WriteLine(resistance1);
            Console.WriteLine(resistanceNeeded);

            /*
            if (temperature < 85 && temperature > -40)
            {
                overTemperature = true;
            }
            else
            {
                overTemperature = false;
            }
            if (current >= 0.03)
            {
                overCurrent = true;
            }
            else
            {
                overCurrent = false;
            }
            */
            Console.ReadKey();
        }
    }
}
