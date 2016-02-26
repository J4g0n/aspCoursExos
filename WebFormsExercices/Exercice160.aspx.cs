using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice160 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void valider_Click(object sender, EventArgs e)
        {
            String nameText = name.Text;
            String passwordText = password.Text;
            String selectedCountry = country.SelectedItem.Text;

            FrontData.SessionExercice160 session = new FrontData.SessionExercice160(nameText, passwordText, selectedCountry);
            Session.Add("userInfo", session);

            Response.Redirect("Exercice160Bis.aspx");
        }
    }
}