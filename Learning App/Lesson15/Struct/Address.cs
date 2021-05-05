using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15
{
    struct Address
    {
        public string AddressName;
        public int HouseNr;
        public int FlatNr;

        public string PostCode;

        public Address(string addressName, int houseNr, int flatNr, string postCode)
        {
            AddressName = addressName;
            HouseNr = houseNr;
            FlatNr = flatNr;
            PostCode = postCode;
        }
    }
}
