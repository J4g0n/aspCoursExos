using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Response.Write("Bonjour " + i + " fois</br>");
            }
        }
    }
}