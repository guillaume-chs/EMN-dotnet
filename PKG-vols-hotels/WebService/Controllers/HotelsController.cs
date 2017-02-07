using System.Collections.Generic;
using System.Web.Http;
using ResaVoyages.BL.LibVol;
using System;
using System.Globalization;
using ResaVoyages.BL.LibHotel;

namespace WebService.Controllers
{
    [Route("api/hotels")]
    public class HotelsController : ApiController
    {
        [Route("api/hotels/search")]
        public List<Hotel> GetHotels([FromUri]string city, [FromUri]string arrivalDate)
        {
           return Hotel.GetHotelsByCity(city);
        }

        [Route("api/hotels/reservation")]
        public Boolean ReservationHotel([FromUri]int idHotel, [FromUri] int nbRooms)
        {
            return Hotel.reserver(idHotel, nbRooms);
        }
    }
}