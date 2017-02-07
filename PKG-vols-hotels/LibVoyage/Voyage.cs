using ResaVoyages.BL.LibVol;
using System.EnterpriseServices;
using System.Runtime.Serialization;

namespace ResaVoyages.BL.LibVoyage
{
    [DataContract]
    public class Voyage : ServicedComponent
    {
        [DataMember]
        public Vol Vol { get; set; }
        
        [DataMember]
        public Hotel Hotel { get; set; }

        public Voyage(Vol vol/*, Hotel hotel*/)
        {
            this.Vol = vol;
            //this.Hotel = hotel;
        }
    }
}
