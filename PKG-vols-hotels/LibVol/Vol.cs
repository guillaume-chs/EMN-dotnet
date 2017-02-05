﻿using ResaVoyages.DAL.DALVols;
using System;
using System.Collections.Generic;
using System.Data;

namespace ResaVoyages.BL.LibVol
{

    public class Vol
    {
        public int IdVol { get; set; }
        public string Name { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public float Price { get; set; }
        public int Capacity { get; set; }

        public Vol(int idVol, string name, DateTime departureDate, DateTime arrivalDate, string departureCity, string arrivalCity, float price, int capacity)
        {
            this.IdVol = idVol;
            this.Name = name;
            this.DepartureDate = departureDate;
            this.ArrivalDate = arrivalDate;
            this.DepartureCity = departureCity;
            this.ArrivalCity = arrivalCity;
            this.Price = price;
            this.Capacity = capacity;
        }

        public Vol(string name, DateTime departureDate, DateTime arrivalDate, string departureCity, string arrivalCity, float price, int capacity)
        {
            new Vol(0, name, departureDate, arrivalDate, departureCity, arrivalCity, price, capacity);
        }

        public static List<Vol> DataSetToVols(DataSet dataSet)
        {
            List<Vol> vols = new List<Vol>();

            foreach (DataRow vol in dataSet.Tables[DALVols.TABLE_NAME].Rows)
            {
                object[] cols = vol.ItemArray;
                vols.Add(new Vol(
                    Convert.ToInt32(cols[0]),
                    Convert.ToString(cols[1]),
                    Convert.ToDateTime(cols[2]),
                    Convert.ToDateTime(cols[3]),
                    Convert.ToString(cols[4]),
                    Convert.ToString(cols[5]),
                    Convert.ToSingle(cols[6]),
                    Convert.ToInt32(cols[7])
                ));
            }

            return vols;
        }

        /**
         * Renvoie la liste des couples (ville de départ, villes d'arrivée)
         */
        public static Dictionary<string, List<string>> getCities()
        {
            DALVols dalVols = new DALVols();
            List<Vol> vols = DataSetToVols(dalVols.GetVols());

            Dictionary<string, List<string>> travels = new Dictionary<string, List<string>>();
            List<string> cities = new List<string>();

            foreach (Vol v in vols)
            {
                if (!cities.Contains(v.DepartureCity))
                {
                    cities.Add(v.DepartureCity);
                }
            }

            cities.ForEach(city =>
            {
                travels.Add(city, vols.FindAll(v => v.DepartureCity == city).ConvertAll(v => v.ArrivalCity));
            });

            return travels;
        }
    }
}
