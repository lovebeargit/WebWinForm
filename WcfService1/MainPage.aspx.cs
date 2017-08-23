using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfService1
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.StuModel stu = new Model.StuModel();
            stu.id = 1;
            stu.stuname = "yoki";
            Service1 wCFTestClient = new Service1();
            TextBox1.Text= wCFTestClient.getname(stu);
        }
    }
}