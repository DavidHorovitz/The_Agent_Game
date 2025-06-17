using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Agent_Game
{
    internal class Dict_Sensors
    {
        public Dictionary<string, int> sensorsDict;
        public void InitSensorDict(List<Create_Sensor> weaknesses)
        {
            sensorsDict = new Dictionary<string, int>();
            foreach (var sensor in weaknesses)
            {
                string key = sensor.Type;
                if (sensorsDict.ContainsKey(key))
                    sensorsDict[key]++;
                else
                    sensorsDict[key] = 1;
            }
        }
        public Dict_Sensors(List<Create_Sensor> weaknesses)
        {
            InitSensorDict(weaknesses);
        }
        
    }
}
