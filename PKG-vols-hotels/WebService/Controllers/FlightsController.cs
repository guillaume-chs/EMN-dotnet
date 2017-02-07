using System.Collections.Generic;
using System.Web.Http;
using ResaVoyages.BL.LibVol;
using System;
using System.Globalization;

namespace WebService.Controllers
{
    [Route("api/flights")]
    public class FlightsController : ApiController
    {

        [Route("api/flights/search")]
        public List<Vol> GetVols([FromUri]string departureCity, [FromUri]string arrivalCity, [FromUri]string departureDate)
        {
            return Vol.GetVols(DateTime.ParseExact(departureDate, "dd/MM/yyyy", CultureInfo.InvariantCulture), departureCity, arrivalCity);
        }

        [Route("api/flights/reservation")]
        public Boolean ReservationFlight([FromUri]int idFlight, [FromUri] int nbRooms)
        {
            return Vol.reserver(idFlight, nbRooms);
        }
    }
}