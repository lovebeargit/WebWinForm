using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
using Model;

namespace Services
{
    public class WCFTest : IWCFTest
    {
        public void Test(StuModel stu)
        {
            
        }


        public string TestStr(StuModel stu)
        {
            return "Stu name is " + stu.stuname;
        }
    }
}
