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
using kechangTest.Structure;

namespace kechangTest
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataTable table = new DataTable();
        string name;

        protected void Page_Load(object sender, EventArgs e)
        {
            name = (string)Session["username"];
            Label1.Text = "Welcome " + name;
            table = (DataTable)Session["test1"];

            if (!IsPostBack)
            {
                GridView1.DataSource = table;
                GridView1.DataBind();
            }
        }

        //http://stackoverflow.com/questions/19874786/add-check-box-to-gridview

        public void onClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.ID == "backBtn")
            {
                // Label1.Text = "back";
                Response.Redirect("Default.aspx", true);
            }

            else if (b.Text == "Delete")
            {

                string username = null;
                // Select the checkboxes from the GridView control
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    GridViewRow row = GridView1.Rows[i];
                    bool isChecked = ((CheckBox)row.FindControl("chkSelect")).Checked;

                    if (isChecked)
                    {
                        username = GridView1.Rows[i].Cells[1].Text;
                        table = infoTable.removeAccount(table, username);
                    }
                }

                //update Session
                Session["test1"] = table;
                GridView1.DataSource = Session["test1"];
                GridView1.DataBind();
            }
        }

        public void sortClick(object sender, GridViewSortEventArgs e)
        {
            DataTable dt = (DataTable)Session["test1"];

            if (dt != null)
            {
                dt.DefaultView.Sort = e.SortExpression + " ASC";
                GridView1.DataSource = Session["test1"];
                GridView1.DataBind();
            }

        }
    }
}
