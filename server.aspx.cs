using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class server : System.Web.UI.Page
{
    data_layer dl = new data_layer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Label2.Text = "";
        }
        
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if(CheckBox1.Checked==true)
        {
            Panel1.Visible = true;
        }
        if (CheckBox1.Checked == false)
        {
            Panel1.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = TextBox1.Text.ToString();
        string str = s.Trim();
        dl.submit_data(str);
        Label2.ForeColor = System.Drawing.Color.Green;
        Label2.Text = "Data inserted successfully";
        Response.Redirect("server.aspx");
       /* var q = dl.show_data();
        if (q.Any())
        {
            GridView1.DataSource = q;
            GridView1.DataBind();
        }
       */

    }
}