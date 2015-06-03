using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SClient;

public partial class Controls_ClientsList : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = Client.GetClients();
        GridView1.DataBind();
    }
}