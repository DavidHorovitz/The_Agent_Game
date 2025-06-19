using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Agent_Game
{
    internal class Game_Maneger
    {
        Service service = new Service();  
        public void menu()
        {
            Console.WriteLine("Menu \n To start press 1 \n To exit press 2");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("The game is starting, \nplease enter the agent's name.");
                string name = Console.ReadLine();
                Agent_junior Create_agent_junior = new Agent_junior(name);
                int Initial_guess_total = service.SumSensorValues();
                
                int numOfLoops = Initial_guess_total;
                do
                {
                    Initial_guess_total = service. SumSensorValues();
                    List<string> sensor_user = new List<string>();
                    //Console.WriteLine($"Initial total = {Initial_guess_total}");
                    for (int i = 0; i < numOfLoops; i++)
                    {
                        if (Initial_guess_total != 0)
                        {
                            Console.Write($"Enter guess {i + 1}: ");
                            string user_guess = Console.ReadLine();
                            sensor_user.Add(user_guess);
                            service.audio.Activate(sensor_user[i], service.GetSensorsDict());
                            Console.WriteLine($"{service.audio.sumOfSensors}/{numOfLoops}");
                            Initial_guess_total = service.SumSensorValues();
                        }
                    }
                    
                } while (Initial_guess_total != 0);
            }
        }
    }
}
