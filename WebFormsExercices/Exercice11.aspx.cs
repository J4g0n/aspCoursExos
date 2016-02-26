using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            labelDate.Text = calendar.SelectedDate.ToString();
        }
    }
}