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
    public partial class _Default : System.Web.UI.Page
    {
        DataTable asdf = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            //loads different session tables 
            if (Session["test1"] == null)
            {
                asdf = infoTable.GetTable();
                Session["test1"] = asdf;
                //asdf = (DataTable)Session["test1"];
            }
            else
            { 
                asdf = (DataTable)Session["test1"];
            }

            GridView1.DataSource = asdf;
            GridView1.DataBind();
        }

        public void onClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.ID == "logInBtn")
            {
                string errorText;
                string username = userText.Text.Trim();
                string password = passText.Text.Trim();
 
                //No string in textbox error
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    errorText = "Invalid Log In";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + errorText + "');", true);
                } 

               //Username not found error
                else if (!(infoTable.searchExists(asdf, username)))
                {
                    errorText = "Username not found";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + errorText + "');", true);
                }

                else 
                {
                    if (infoTable.isCorrectAccount(asdf, username, password))
                    {
                        Session["username"] = username;
                        Response.Redirect("WebForm3.aspx", true);
                    }
                    else
                    {
                        errorText = "Account information does not match";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + errorText + "');", true);
                    }
                }
            }
            else if (b.ID == "registerBtn")
            {
                Response.Redirect("WebForm2.aspx", true);
            }
            else if (b.ID == "searchBtn")
            {
                Response.Redirect("Search.aspx", true);
            }
        }
    }
}
