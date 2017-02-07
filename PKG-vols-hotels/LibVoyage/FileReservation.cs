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
    class FileReservation : ServicedComponent
    {
        [AutoComplete]
        public Voyage LireFile()
        {
            MessageQueue file = new MessageQueue(@".\private$\fileResa");
            file.Formatter = new XmlMessageFormatter(new Type[] { typeof(Voyage) });

            Voyage voyage = (Voyage)file.Peek().Body;

            file.Receive();
            file.Close();

            return voyage;
        }
    }
}
