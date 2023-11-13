using System;
using System.Collections.Generic;

namespace FaultySensor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sensorService = new SensorService();

            var faultySensorInfo = sensorService.GetFaultySensorInfo(GetSensorData());

            Console.WriteLine("\n\nFaulty Sensor Information");
            Console.WriteLine("-----------------------------------\n");

            if (faultySensorInfo == null)
            {
                Console.WriteLine("All sensors are working fine");
                Console.WriteLine("Cost Of replacement : 0");
                Console.WriteLine(" Status: GREEN");
            }
            else
            {
                PrintFaultySensor(faultySensorInfo);
            }

            Console.ReadLine();
        }

        static void PrintFaultySensor(List<FaultySensorInfo> faultyList)
        {
            if (faultyList.Count == 1)
            {
                Console.WriteLine($"Output: Sensor [{faultyList[0].FaultySensorId} of {faultyList[0].MachineId}] out of range");
                Console.WriteLine($"Cost of Replacement: {faultyList[0].SensorCost}");
                Console.WriteLine("Status: Warning");
            }
            else
            {
                int totalCost = 0;
                string outputSensor = "Output: Sensor ";

                foreach (var faulty in faultyList)
                {
                    outputSensor += $"[{faulty.FaultySensorId} of {faulty.MachineId}],";
                    totalCost += (int)faulty.SensorCost;
                }

                outputSensor += " are out of range";

                Console.WriteLine(outputSensor);
                Console.WriteLine($"Cost of Replacement: {totalCost}");
                Console.WriteLine("Status: RED");
            }
        }

        static string toBeContinue = "No";
        static List<SensorData> GetSensorData()
        {
            Console.WriteLine("Plant Maintenance Cost Analyzer");
            Console.WriteLine("-----------------------------------\n");

            List<SensorData> sensorList = new List<SensorData>();

            do
            {
                SensorData sensorData = new SensorData();

                Console.WriteLine("Enter the Vendor ID");
                sensorData.VendorId = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter the Machine ID");
                sensorData.MachineId = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter the Sensor ID");
                sensorData.SensorId = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter the Sensor value");
                sensorData.SensorValue = Convert.ToDouble(Console.ReadLine());

                if (!string.IsNullOrEmpty(sensorData.VendorId) && !string.IsNullOrEmpty(sensorData.MachineId) &&
                    !string.IsNullOrEmpty(sensorData.SensorId) && sensorData.SensorValue >= 0)
                {
                    sensorList.Add(sensorData);
                }
                else
                {
                    Console.WriteLine("Value should not be null or zero.");
                }

                Console.WriteLine("Enter another data. Press y");
                toBeContinue = Console.ReadLine();

            } while (toBeContinue.ToLower() == "y");

            return sensorList;
        }
    }

    public class SensorService
    {
        public List<FaultySensorInfo> GetFaultySensorInfo(List<SensorData> sensorDataList)
        {
            List<FaultySensorInfo> faultySensorCollection = new List<FaultySensorInfo>();

            foreach (var sensorData in sensorDataList)
            {
                if (IsSensorValueOutOfRange(sensorData.SensorValue))
                {
                    faultySensorCollection.Add(new FaultySensorInfo
                    {
                        FaultySensorId = sensorData.SensorId,
                        SensorValue = sensorData.SensorValue,
                        SensorCost = GetSensorCost(sensorData.MachineId)
                    });
                }
            } 
        }
    }