using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.ServiceModel;

namespace Interface
{
    [ServiceContract] 
    public interface IWCFTest
    {

        [OperationContract] 
        void Test(StuModel stu);

        [OperationContract]
        string TestStr(StuModel stu);
    }
}
