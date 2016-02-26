using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice160Bis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FrontData.SessionExercice160 session = (FrontData.SessionExercice160)(Session["userInfo"]);

            name.Text = session.name;
            password.Text = session.password;
            country.Text = session.country;
        }
    }
}