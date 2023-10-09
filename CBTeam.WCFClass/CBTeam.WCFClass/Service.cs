using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CBTeam.WCFClass
{
    public class Service : IService
    {
        List<Address> address = new List<Address>
        {
            new Address{AddressName = "Libertad",
                AddressNumber = 883,},
            new Address{AddressName = "Canada",
                AddressNumber = 260,},
            new Address{AddressName = "Venezuela",
                AddressNumber = 223,},
            new Address{AddressName = "1 de Mayo",
                AddressNumber = 191,},
            new Address{AddressName = "Jose Hernandez",
                AddressNumber = 1920,},
            new Address{AddressName = "Hipolito Irigoyen",
                AddressNumber = 235,},
        };

        public List<Address> GetAddress() 
        { return address; }
    }
}
