using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Address
    {
        private int houseNo, roadNo;
        private string city;

        public Address(int houseNo, int roadNo, string city)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.city = city;
        }

        public int HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public int RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string GetAddress()
        {
            return "Address:House No-{0}, Road No-{1}, City-{2} "+this.houseNo+" "+this.roadNo+" "+this.city;
        }
    }
}
