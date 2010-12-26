using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wikipedia
{
    public partial class Domain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var eds = new Data.WikipediaEntities();
            var art = eds.Articles.First();
            Debug.Text = art.Domain.Name;
        }
    }
}