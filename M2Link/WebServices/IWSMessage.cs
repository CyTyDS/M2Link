using M2Link.WebServiceModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace M2Link.WebServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IWSMessage" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWSMessage
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        Collection<MessageModel> GetMessages(Guid user);
        [OperationContract]
        MessageModel CreateMessage(Guid user, string messageContent);
    }
}
