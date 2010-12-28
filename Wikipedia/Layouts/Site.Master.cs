using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wikipedia
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        public string SearchText
        {
            get { return SearchBar.Text; }
            set { SearchBar.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.IsInRole("Admin"))
            {
                admin.Visible = false;
            }
        }
    }
}
