using System.Collections.Generic;
using System.Web.Http;
using ResaVoyages.BL.LibVoyage;
using System;
using System.Globalization;
using ResaVoyages.BL.LibHotel;
using ResaVoyages.BL.LibVol;

namespace WebService.Controllers
{
    [Route("api/reserver")]
    public class ReservationController : ApiController
    {
        public void Get([FromUri] int hotelId, [FromUri] int volId, [FromUri] string nom, [FromUri] string prenom)
        {
            var volById = Vol.GetVolById(volId);
            var hotelById = Hotel.GetHotelById(hotelId);
            var voyage = new Voyage(volById, hotelById);
            voyage.nom = nom;
            voyage.prenom = prenom;
            FileReservation.EcrireFile(voyage);
        }

        public void Post([FromBody] int hotelId, [FromBody] int volId, [FromBody] string nom, [FromBody] string prenom)
        {
            var volById = Vol.GetVolById(volId);
            var hotelById = Hotel.GetHotelById(hotelId);
            var voyage = new Voyage(volById, hotelById);
            voyage.nom = nom;
            voyage.prenom = prenom;
            FileReservation.EcrireFile(voyage);
        }
    }
}