using FaultySensor.Model;

using FaultySensor.Repository;

using FaultySensor.Service;



namespace FaultySensor

{

    public class Program

    {

        public static void Main(string[] args)

        {

            var sensorLookupRepository = new SensorLookupRepository();

            var sensorService = new SensorService(sensorLookupRepository);



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

            Console.WriteLine("Plant Maintaince Cost Analzer");

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

                sensorData.SensorValue = Convert.ToInt32(Console.ReadLine());



                if (sensorData.VendorId != null && sensorData.MachineId != null && sensorData.SensorId != null && sensorData.SensorValue >= 0)

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

}