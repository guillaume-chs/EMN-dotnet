using System.Collections.Generic;
using System.Web.Http;
using ResaVoyages.BL.LibVol;
using System;
using System.Globalization;

namespace WebService.Controllers
{
    [Route("api/hotels")]
    public class HotelsController : ApiController
    {

        [Route("api/hotels/search")]
        public List<Vol> GetVols([FromUri]string city, [FromUri]string arrivalDate)
        {
            //return Vol.GetVols(DateTime.ParseExact(departureDate, "dd/MM/yyyy", CultureInfo.InvariantCulture), departureCity, arrivalCity);
            return new List<Vol>(0);
        }
    }
}