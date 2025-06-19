using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Agent_Game
{
    internal class Service
    {
        public Service()
        {
            list_sensor_weakness(); 
        }

        public Sensor_Basic audio;
        private Dictionary<string, int> sensorsDictWeakness = new Dictionary<string, int>();
        public void list_sensor_weakness()
        {
            audio = new Sensor_Basic("audio");
            Sensor_Basic Viewing = new Sensor_Basic("Viewing");
            List<Sensor_Basic> sensorsList = new List<Sensor_Basic> { audio, Viewing };
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                Sensor_Basic randomSensor = sensorsList[rnd.Next(sensorsList.Count)];
                Weakness_Dictionary(randomSensor.Type);
            }
        }
        public void Weakness_Dictionary(string sensor)
        {

            if (sensorsDictWeakness.ContainsKey(sensor))
                sensorsDictWeakness[sensor]++;
            else
                sensorsDictWeakness[sensor] = 1;

        }
        public int SumSensorValues()
        {
            int sum = 0;

            foreach (var val in sensorsDictWeakness.Values)

            {
                sum += val;
            }
            return sum;
        }
        public Dictionary<string, int> GetSensorsDict()
        {

            return sensorsDictWeakness;
        }
    }
}
