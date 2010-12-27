using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wikipedia
{
    public partial class ImageUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void UploadClick(object sender, EventArgs e)
        {
            if (File.HasFile)
            {
                byte[] buffer = new byte[File.PostedFile.ContentLength];
                File.PostedFile.InputStream.Read(buffer, 0, File.PostedFile.ContentLength);

                using (var eds = new Data.WikipediaEntities())
                {
                    var img = new Data.Image();
                    img.Content = buffer;
                    img.ContentType = File.PostedFile.ContentType;
                    img.ContentLength = File.PostedFile.ContentLength;
                    
                    eds.Images.AddObject(img);
                    eds.SaveChanges();

                    Response.Redirect("~/Image.ashx?id=" + img.Id);
                }
            }
        }
    }
}