using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pays = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pays
            // 
            this.pays.Location = new System.Drawing.Point(267, 68);
            this.pays.Name = "pays";
            this.pays.Size = new System.Drawing.Size(100, 20);
            this.pays.TabIndex = 1;
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(282, 179);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 3;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(303, 240);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 4;
            this.result.Text = "result";
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(267, 118);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(100, 20);
            this.ville.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(670, 522);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.result);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.pays);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codePays = pays.Text;
            string codeVille = ville.Text;

            ServiceMeteoPlus.ServiceMeteoClient serviceMeteo = new ServiceMeteoPlus.ServiceMeteoClient();
            result.Text = serviceMeteo.PrevisionMeteo(codePays, codeVille, "", "").ToString();
        }
    }
}
