using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExercices
{
    public partial class Exercice6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void valider_Click(object sender, EventArgs e)
        {
            if (file_upload.HasFile)
            {
                try
                {
                    System.IO.Stream fs = file_upload.PostedFile.InputStream;
                    System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                    Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

                    photo_upload.ImageUrl = "data:image/jpeg;base64," + base64String;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while selecting file");
                }
            }
        }
    }
}