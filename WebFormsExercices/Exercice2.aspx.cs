using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Response.Write(c + " ");
                if (c == 'M')
                {
                    Response.Write("</br>");
                }
            }
        }
    }
}