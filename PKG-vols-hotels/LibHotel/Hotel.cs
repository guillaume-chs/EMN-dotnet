using ResaVoyages.DAL.DALHotels;
using System;
using System.Collections.Generic;
using System.Data;
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

         protected static List<Hotel> DataSetToHotels(DataSet dataSet)
        {
            List<Hotel> hotels = new List<Hotel>();

            if (dataSet.Tables.Count == 1 && dataSet.Tables.Contains(DALHotels.TABLE_NAME))
            {
                foreach (DataRow hotel in dataSet.Tables[DALHotels.TABLE_NAME].Rows)
                {
                    object[] cols = hotel.ItemArray;
                    hotels.Add(new Hotel(
                        Convert.ToInt32(cols[0]),
                        Convert.ToString(cols[1]),
                        Convert.ToString(cols[2]),
                        Convert.ToSingle(cols[3]),
                        Convert.ToInt32(cols[4])
                    ));
                }
            }

            return hotels;
        }

        public static List<Hotel> GetHotelsByCity(String city)
        {
            DALHotels dalHotels = new DALHotels();
            List<Hotel> hotels = DataSetToHotels(dalHotels.GetHotelsByCity(city));

            return hotels;
        }


        public static void reserver(int idHotel, int nbRooms, string nom, string prenom)
        {
            DALHotels dalHotels = new DALHotels();

            if (Convert.ToInt32(dalHotels.GetHotelCapacityById(idHotel).Tables[0].Rows[0]["CAPACITY"].ToString()) > nbRooms)
            {
                dalHotels.DecrementHotelSeatsById(idHotel, nbRooms);
                
                dalHotels.InsertReservationHotel(nom, prenom, nbRooms, idHotel);
            }

        }

    }
}
