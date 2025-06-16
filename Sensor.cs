using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Agent_Game
{
    internal abstract class Sensor
    {
        
        public abstract string Type { get; }
        public abstract void Activate(Dictionary<string, int> sensorsDict, List<string> user_sensor);
        

    }
        
}
