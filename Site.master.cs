using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            ViewState.Add("Young","IamYoung");
        }

        ViewState["Young"] = "IamYoungIamYoungIamYoungIamYoungIamYoungIamYoung";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("/Testpage1.aspx");
        Server.Transfer("/Testpage1.aspx");
    }
}
