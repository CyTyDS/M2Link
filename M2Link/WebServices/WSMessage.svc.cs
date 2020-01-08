using M2Link.WebServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace M2Link.WebServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "WSMessage" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez WSMessage.svc ou WSMessage.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class WSMessage : IWSMessage
    {
        public void DoWork()
        {
        }

        public void GetMessages(UserModel user)
        {

        }
        public void CreateMessage()
        {

        }

    }
}
