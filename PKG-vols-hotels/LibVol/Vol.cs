using System;
using System.Collections.Generic;
using System.Data;
using ResaVoyages.DALVols;

namespace ResaVoyages.LibVol
{
    public class Vol
    {
        private int idVol { get; set; }
        private string name { get; set; }
        private DateTime departureDate { get; set; }
        private DateTime arrivalDate { get; set; }
        private string departureCity { get; set; }
        private string arrivalCity { get; set; }
        private float price { get; set; }
        private int capacity { get; set; }

        public Vol(int idVol, string name, DateTime departureDate, DateTime arrivalDate, string departureCity, string arrivalCity, float price, int capacity)
        {
            this.idVol = idVol;
            this.name = name;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.departureCity = departureCity;
            this.arrivalCity = arrivalCity;
            this.price = price;
            this.capacity = capacity;
        }

        public Vol(string name, DateTime departureDate, DateTime arrivalDate, string departureCity, string arrivalCity, float price, int capacity)
        {
            new Vol(0, name, departureDate, arrivalDate, departureCity, arrivalCity, price, capacity);
        }

        public static List<Vol> dataSetToVols(DataSet dataSet)
        {
            List<Vol> vols = new List<Vol>();

            foreach (DataRow vol in dataSet.Tables[Vols.TABLE_NAME].Rows)
            {
                object[] cols = vol.ItemArray;
                vols.Add(new Vol(
                    (int) cols[0],
                    (string) cols[1],
                    (DateTime) cols[2],
                    (DateTime) cols[3],
                    (string) cols[4],
                    (string) cols[5],
                    (float) cols[6],
                    (int) cols[7]
                ));
            }

            return vols;
        }
    }
}
