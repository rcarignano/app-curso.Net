using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CBTeam.WCFClass
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Address> GetAddress();
    }

    [DataContract]
    public class Address
    {
        [DataMember]
        public string AddressName { get; set; }
        [DataMember]
        public int AddressNumber { get; set; }

    }
}
