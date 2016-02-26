using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsExercices.FrontData;

namespace WebFormsExercices
{
    public partial class Exercice180 : System.Web.UI.Page
    {
        static AgentRepository agentRepository = new AgentRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            Agent a = agentRepository.GetCurrentAgent();
            precedent.Visible = agentRepository.HasPreviousAgent();
            suivant.Visible = agentRepository.HasNextAgent();
            nomAgent.Text = a.name;
        }

        protected void suivant_Click(object sender, EventArgs e)
        {
            if (agentRepository.HasNextAgent())
            {
                agentRepository.GetNextAgent();
                Agent a = agentRepository.GetCurrentAgent();
                precedent.Visible = agentRepository.HasPreviousAgent();
                suivant.Visible = agentRepository.HasNextAgent();
                nomAgent.Text = a.name;
            }
        }

        protected void precedent_Click(object sender, EventArgs e)
        {
            if (agentRepository.HasPreviousAgent())
            {
                agentRepository.GetPreviousAgent();
                Agent a = agentRepository.GetCurrentAgent();
                precedent.Visible = agentRepository.HasPreviousAgent();
                suivant.Visible = agentRepository.HasNextAgent();
                nomAgent.Text = a.name;
            }
        }
    }
}