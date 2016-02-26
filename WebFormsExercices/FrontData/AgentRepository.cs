using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsExercices.FrontData
{
    public class Agent
    {
        public string id;
        public string name;
        public string age;
        public string address;

        public Agent(string id, string name, string age, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
        }
    }

    public class AgentRepository
    {
        List<Agent> agents = new List<Agent>();
        int index = 0;
        static string pathToFile = "C:\\Users\\ipi\\Desktop\\visual studio 2015\\Projects\\MaSolutionVisualStudio\\WebFormsExercices\\Resources\\agentes.txt";

        public AgentRepository()
        {
            this.agents = AgentRepository.LoadAgents();
        }

        public static List<Agent> LoadAgents()
        {
            List<Agent> agents = new List<Agent>();
            System.IO.StreamReader file = new System.IO.StreamReader(pathToFile);
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string [] words = line.Trim().Split(';');
                Agent agent = new Agent(words[0], words[1], words[2], words[3]);
                agents.Add(agent);
            }
            return agents;
        }

        public Boolean HasPreviousAgent()
        {
            return index > 0;
        }

        public Boolean HasNextAgent()
        {
            return agents.Count > index + 1;
        }

        public Agent GetCurrentAgent()
        {
            return agents[index];
        }

        public void GetNextAgent()
        {
            index++;
        }

        public void GetPreviousAgent()
        {
            index--;
        }
    }
}