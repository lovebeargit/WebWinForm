using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Services;
using Interface;
using System.ServiceModel.Description;

namespace WCFHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost host = null;//定义 ServiceHost 
        private void button1_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(Services.WCFTest));//WcfDemo.Service1 为引用的dll中的服务 
            host.Open();//启动服务 
            this.label1.Text = "服务已开启"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (host.State != CommunicationState.Closed)//判断服务是否关闭 
            {
                host.Close();//关闭服务 
            }
            this.label1.Text = "服务已关闭"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uri baseAddress = new Uri("http://localhost:8088/");

            //承载服务  
            //1.导入 System.ServiceModel.Description 命名空间。这行代码应该与 using 或 imports 语句的其余部分一起放置在 Program.cs/Program.vb 文件的顶部。  
            //2.创建一个新的 ServiceHost 实例以承载服务。必须指定实现服务协定和基址的类型。对于此示例，基址为 http://localhost:8000/ServiceModelSamples/Service，CalculatorService 为实现服务协定的类型。  
            ServiceHost selfHost = new ServiceHost(typeof(WCFTest), baseAddress);
            //3.添加一个捕获 CommunicationException 的 try-catch 语句，并在接下来的三个步骤中将该代码添加到 try 块中。catch 子句应该显示错误信息，然后调用 selfHost.Abort()。  
            try
            {
                //4.添加公开服务的终结点。为此，必须指定终结点公开的协议、绑定和终结点的地址。对于此示例，将 ICalculator 指定为协定，将 WSHttpBinding 指定为绑定，并将 CalculatorService 指定为地址。在这里请注意，终结点地址是相对地址。终结点的完整地址是基址和终结点地址的组合。在此例中，完整地址是 http://localhost:8000/ServiceModelSamples/Service/CalculatorService。  
                selfHost.AddServiceEndpoint(
                   typeof(IWCFTest),
                   new WSHttpBinding(),
                    "WCFTest");
                //5.启用元数据交换。为此，添加服务元数据行为。首先创建一个 ServiceMetadataBehavior 实例，将 HttpGetEnabled 属性设置为 true，然后为服务添加新行为。  
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                //6.打开 ServiceHost 并等待传入消息。用户按 Enter 键时，关闭 ServiceHost  
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }

        }
    }
}
