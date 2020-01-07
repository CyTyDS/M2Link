using System.ServiceModel;
using M2Link.WebServiceModels;

namespace M2Link.WebServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IWSLogin" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWSLogin
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        string HelloWorld();
        [OperationContract]
        UserModel Validate(string nom, string mdp);
    }

}
