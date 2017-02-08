using ResaVoyages.BL.LibVol;
using ResaVoyages.BL.LibHotel;
using System.Runtime.Serialization;

namespace ResaVoyages.BL.LibVoyage
{
    [DataContract]
    public class Voyage
    {
        [DataMember]
        public Vol Vol { get; set; }
        
        [DataMember]
        public Hotel Hotel { get; set; }

        [DataMember]
        public string nom { get; set; }

        [DataMember]
        public string prenom { get; set; }

        public Voyage(Vol vol, Hotel hotel)
        {
            this.Vol = vol;
            this.Hotel = hotel;
        }

        public Voyage()
        {

        }
    }
}
