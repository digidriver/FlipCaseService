using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlipCaseService
{
    [DataContract]
    public class StringData
    {
        [DataMember]
        public string OriginalString;

        [DataMember]
        public string FlippedCaseString;
    }
}
