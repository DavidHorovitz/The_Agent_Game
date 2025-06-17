using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Agent_Game
{
    internal class Agent_junior : Create_agent
    {
        public Sensor_Basic audio;
        private Dictionary<string, int> sensorsDict = new Dictionary<string, int>();
        public override string Name { get; }
        public Agent_junior(string name)
        {
            this.Name = name;
            list_sensor_weakness();
        }
        public void list_sensor_weakness()
        {
            this.audio = new Sensor_Basic("audio");
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
            if (sensorsDict.ContainsKey(sensor))
                sensorsDict[sensor]++;
            else
                sensorsDict[sensor] = 1;
        }
        public int SumSensorValues()
        {
            int sum = 0;
            foreach (var val in sensorsDict.Values)
            {
                sum += val;
            }
            return sum;
        }
        public Dictionary<string, int> GetSensorsDict()
        {
            return sensorsDict;
        }
    }
}
