using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;

namespace ResaVoyages.BL.LibVoyage
{
    public class FileReservation
    {
        public static void EcrireFile(Voyage voyage)
        {
            MessageQueue file = new MessageQueue(@".\private$\resaVoyage");
            file.Send(voyage);
            file.Close();
        }
    }
}
