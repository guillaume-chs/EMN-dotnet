using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibHotel
{

    [DataContract]
    public class Hotel
    {

        [DataMember]
        public int IdHotel { get; set; }

        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public string City { get; set; }
        
        [DataMember]
        public float Price { get; set; }

        [DataMember]
        public int Capacity { get; set; }

        public Hotel(int idHotel, string name, string city, float price, int capacity)
        {
            this.IdHotel = idHotel;
            this.Name = name;
            this.City = city;
            this.Price = price;
            this.Capacity = capacity;
        }

        public Hotel(string name, string city, float price, int capacity)
        {
            new Hotel(0, name, city, price, capacity);
        }
    }
}
