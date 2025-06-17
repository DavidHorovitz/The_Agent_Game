using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Agent_Game
{
    internal class Sensor_Basic : Sensor
    {
        public int a { get; private set; } = 0;
        public override string Type { get; }
        public Sensor_Basic(string type)
        {
            this.Type = type;
        }
        public override void Activate(string sensor, Dictionary<string, int> sensorsDict)
        {
            if (sensorsDict.ContainsKey(sensor) && sensorsDict[sensor] > 0)
            {
                sensorsDict[sensor]--;
                this.a++;
            }
        }
    }
}
