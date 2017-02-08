using ResaVoyages.BL.LibVol;
using ResaVoyages.BL.LibHotel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Messaging;

namespace ResaVoyages.BL.LibVoyage
{
    public class TransactionVoyage
    {
        public static void Transact()
        {
            MessageQueue file = new MessageQueue(@".\private$\resaVoyage");
            file.Formatter = new XmlMessageFormatter(new Type[] { typeof(Voyage) });

            Voyage voyage = (Voyage)file.Peek().Body;
            
            using (TransactionScope transaction = new TransactionScope())
            {
                Vol.AddReservationVol(voyage.Vol.IdVol, 1, "john", "doe");
                Hotel.InsertReservationHotel(voyage.Hotel.IdHotel, 1, "john", "doe");

                transaction.Complete();

                file.Receive();
            }

            file.Close();
        }
    }
}
