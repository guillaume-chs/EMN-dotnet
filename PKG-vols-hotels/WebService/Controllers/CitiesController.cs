using System.Collections.Generic;
using System.Web.Http;
using ResaVoyages.BL.LibVol;
using System;
using System.Globalization;

namespace WebService.Controllers
{
    [Route("api/cities")]
    public class CitiesController : ApiController
    {
        public List<string> Get()
        {
            return Vol.GetCities();
        }
    }
}