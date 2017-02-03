using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using Microsoft.Ajax.Utilities;
using ResaVoyages.DALVols;
using ResaVoyages.LibVol;

namespace WebService.Controllers
{
    public class FlightsController : ApiController
    {
        public Dictionary<string, List<string>> Get()
        {
            return Vol.getCities();
        }
        
        public List<Vol> GetByDepartureCity(string departureCity)
        {
            // TODO : use DAL
            return Vol.DataSetToVols(new Vols().GetVols()).FindAll(v => v.departureCity == departureCity);
        }
    }
}