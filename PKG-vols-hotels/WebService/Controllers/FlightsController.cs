﻿using System.Collections.Generic;
using System.Web.Http;
using ResaVoyages.BL.LibVol;
using System;
using System.Globalization;

namespace WebService.Controllers
{
    [Route("api/flights")]
    public class FlightsController : ApiController
    {
        public Dictionary<string, List<string>> Get()
        {
            return Vol.GetCities();
        }

        [Route("api/flights/search")]
        public List<Vol> GetVols([FromUri]string departureCity, [FromUri]string arrivalCity, [FromUri]string departureDate)
        {
            return Vol.GetVols(DateTime.ParseExact(departureDate, "dd/MM/yyyy", CultureInfo.InvariantCulture), departureCity, arrivalCity);
        }
    }
}