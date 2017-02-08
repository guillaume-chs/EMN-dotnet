using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.EnterpriseServices;
using System.Messaging;

namespace ResaVoyages.BL.LibVoyage
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(), Description("File de reservations de voyages")]
    public class FileReservation : ServicedComponent
    {
        [AutoComplete]
        public static Voyage LireFile()
        {
            MessageQueue file = new MessageQueue(@".\private$\ResaVoyage");
            file.Formatter = new XmlMessageFormatter(new Type[] { typeof(Voyage) });

            Voyage voyage = (Voyage)file.Peek().Body;

            file.Receive();
            file.Close();

            return voyage;
        }

        [AutoComplete]
        public static void EcrireFile(Voyage voyage)
        {
            MessageQueue file = new MessageQueue(@".\private$\ResaVoyage");
            file.Send(voyage);
            file.Close();
        }
    }
}
