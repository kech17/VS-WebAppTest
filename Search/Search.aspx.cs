using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


namespace kechangTest
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                searchResults.Visible = false;
            }
            else
            {
                searchResults.Visible = true;
            }
            
        }

        protected void searchClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.ID == "searchStart")
            {
                DataView dv = new DataView();
                dv = (DataView)searchResults.DataSource;
                dv.RowFilter = string.Format("Field = '{0}'", userTextSearch.Text);

                searchResults.DataSource = dv.ToTable();
            }

        }


    }
}
