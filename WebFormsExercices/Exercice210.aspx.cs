using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice210 : System.Web.UI.Page
    {
        static string sexe = "";
        static string status = "";
        static string sport = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            precedent.Visible = multiview.ActiveViewIndex > 0;
            suivant.Visible = multiview.ActiveViewIndex < 3;
            lblSexe.Visible = multiview.ActiveViewIndex == 3;
            lblStatus.Visible = multiview.ActiveViewIndex == 3;
            lblSport.Visible = multiview.ActiveViewIndex == 3;
            sauvegarder.Visible = multiview.ActiveViewIndex == 3;
            refaire.Visible = multiview.ActiveViewIndex == 3;
        }

        protected void suivant_Click(object sender, EventArgs e)
        {
            multiview.ActiveViewIndex++;
            precedent.Visible = multiview.ActiveViewIndex > 0;
            suivant.Visible = multiview.ActiveViewIndex < 3;
            if (multiview.ActiveViewIndex == 3)
            {
                lblSexe.Text = sexe;
                lblStatus.Text = status;
                lblSport.Text = sport;
                lblSexe.Visible = multiview.ActiveViewIndex == 3;
                lblStatus.Visible = multiview.ActiveViewIndex == 3;
                lblSport.Visible = multiview.ActiveViewIndex == 3;
                sauvegarder.Visible = multiview.ActiveViewIndex == 3;
                refaire.Visible = multiview.ActiveViewIndex == 3;
            }

        }

        protected void precedent_Click(object sender, EventArgs e)
        {
            multiview.ActiveViewIndex--;
            precedent.Visible = multiview.ActiveViewIndex > 0;
            suivant.Visible = multiview.ActiveViewIndex < 3;
        }

        protected void btnHomme_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "homme";
        }

        protected void btnFemme_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "femme";
        }

        protected void btnEtudiant_CheckedChanged(object sender, EventArgs e)
        {
            status = "etudiant";
        }

        protected void btnSalarie_CheckedChanged(object sender, EventArgs e)
        {
            status = "salarie";
        }

        protected void btnSport_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBasket.Checked)
            {
                sport = "basket";
            }
            if (btnFootball.Checked)
            {
                sport = "football";
            }
            if (btnRugby.Checked)
            {
                sport = "rugby";
            }
            if (btnAucunSport.Checked)
            {
                sport = "aucun sport";
            }
        }

        protected void refaire_Click(object sender, EventArgs e)
        {
            multiview.ActiveViewIndex = 0;
            precedent.Visible = multiview.ActiveViewIndex > 0;
            suivant.Visible = multiview.ActiveViewIndex < 3;
            lblSexe.Visible = multiview.ActiveViewIndex == 3;
            lblStatus.Visible = multiview.ActiveViewIndex == 3;
            lblSport.Visible = multiview.ActiveViewIndex == 3;
            sauvegarder.Visible = multiview.ActiveViewIndex == 3;
            refaire.Visible = multiview.ActiveViewIndex == 3;
        }
    }
}