using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Agent_Game
{
    internal class Agent_junior : Create_agent

    {

        Service service = new Service();
        public override string Name { get; }

        public Agent_junior(string name)
        {
            this.Name = name;
            service. list_sensor_weakness();
        }
     

    }
}
