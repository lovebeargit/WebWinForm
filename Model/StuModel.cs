using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class StuModel
    {
        private int _id;
        private string _stuname;

        [DataMember]
        public int id
        {
            set { _id =value; }
            get { return _id; }
        }

        [DataMember]
        public string stuname
        {
            set { _stuname = value; }
            get { return _stuname; }
        }
    }
}
