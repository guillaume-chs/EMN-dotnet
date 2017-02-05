using System.Collections.Generic;
using System.Web.Http;
using ResaVoyages.BL.LibVol;
using ResaVoyages.DAL.DALVols;

namespace WebService.Controllers
{
    [Route("api/flights")]
    public class FlightsController : ApiController
    {
        public Dictionary<string, List<string>> Get()
        {
            return Vol.getCities();
        }
        
        public List<Vol> GetByDepartureCity(string departureCity)
        {
            // TODO : use DAL
            return Vol.DataSetToVols(new DALVols().GetVols()).FindAll(v => v.DepartureCity == departureCity);
        }
    }
}