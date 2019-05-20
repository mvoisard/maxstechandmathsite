using System;

namespace WebApplication6
{
    public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = "ID: " + DropDownList1.SelectedValue;
        }
    }
}