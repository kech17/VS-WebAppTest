using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace kechangTest.Structure
{
    public class infoTable : DataTable
    {
        //int maxRows;
        //int maxColumns;
        DataTable table;

        public infoTable()
        {
            //table = GetTable();
           // maxRows = 4;
           // maxColumns = 3;
            //dataGridView1.DataSource = table;
        }

        public static DataTable GetTable()
        {
            //Hard coded usernames and passwords
            
            DataTable table = new DataTable();
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Date Registered", typeof(DateTime));

            table.Rows.Add("kechang", "12345", DateTime.Now);
            table.Rows.Add("qwert", "12345", DateTime.Now);
            table.Rows.Add("asdf", "12345", DateTime.Now);
            table.Rows.Add("zxcv", "12345", DateTime.Now);
            table.Rows.Add("asd", "asd", DateTime.Now);
            //random class to populate
            Random random = new Random();
            int rand;

            for (int i = 0; i < 20; i++)
            {
                rand = random.Next(999, 5000);

                table.Rows.Add("dummy", rand, DateTime.Now);
            }
                
            return table;
        }

        //true if exists
        public static bool searchExists(DataTable table, string username)
        {

            foreach (DataRow row in table.Rows)
            {
                if (row["Username"].ToString() == username)
                {
                    return true;
                }
            }
            return false;            
        }

        public static bool isCorrectAccount(DataTable table, string username, string password)
        {
            //DataTable table = (DataTable)Session["test1"];
            //DataRow[] findItem = table.Select(String.Format("Username ='{0}'", username));
            foreach (DataRow row in table.Rows)
            {
                if (row["Username"].ToString()== username &&
                    row["Password"].ToString() == password)
                    return true;
            }
            return false;
        }

       public static DataTable addAccount(DataTable table, string username, string password)
        {
            table.Rows.Add(username, password, 
                DateTime.Now);
            return table;
        }

        public static DataTable removeAccount(DataTable table, string username)
        {
            DataRow row;
            for (int i=0;i<table.Rows.Count;i++)
            {
                row = table.Rows[i];
                if (row["Username"].ToString() == username)
                {
                    table.Rows.Remove(row);
                }
            }
            
            return table;
        }
    }
}


