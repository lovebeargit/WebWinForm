using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WCFClient.WCFTest;
using System.ServiceModel;



namespace WCFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.StuModel stu = new Model.StuModel();
            stu.id = 1;
            stu.stuname = "yoki";
            
            WCFTest.WCFTestClient wCFTestClient = new WCFTest.WCFTestClient();
            wCFTestClient.Test(stu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model.StuModel stu = new Model.StuModel();
            stu.id = 1;
            stu.stuname = "yoki";

            WCFTest.WCFTestClient wCFTestClient = new WCFTest.WCFTestClient();
            MessageBox.Show( wCFTestClient.TestStr(stu));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Model.StuModel stu = new Model.StuModel();
            //stu.id = 2;
            //stu.stuname = "yy";

            //EndpointAddress epAddress = new EndpointAddress("http://localhost:8088/");
            //Service1Client c = new Service1Client();


            //MessageBox.Show(c.getname(stu));
        }
    }
}
