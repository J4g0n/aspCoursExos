using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int N = 10;
            for (int row = 0; row<N; row++)
            {
                System.Drawing.Color evenColor;
                System.Drawing.Color oddColor;

                TableRow tableRow = new TableRow(); 

                if (row % 2 == 1)
                {
                    evenColor = System.Drawing.Color.Black;
                    oddColor = System.Drawing.Color.White;
                }
                else
                {
                    evenColor = System.Drawing.Color.White;
                    oddColor = System.Drawing.Color.Black;
                }
                for (int column = 0; column< N; column++)
                {
                    TableCell tableCell = new TableCell();
                    if (column % 2 == 1)
                    {
                        tableCell.BackColor = oddColor;
                    }
                    else
                    {
                        tableCell.BackColor = evenColor;
                    }

                    tableRow.Cells.Add(tableCell);
                }

                tableDamier.Rows.Add(tableRow);
            }
        }
    }
}