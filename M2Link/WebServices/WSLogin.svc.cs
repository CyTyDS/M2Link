using M2Link.Entities;
using M2Link.Repositories;
using M2Link.WebServiceModels;


namespace M2Link.WebServices
{
    public class WSLogin : IWSLogin
    {
        public void DoWork()
        {
        }
        public string HelloWorld()
        {
            return "Hello World";
        }

        public UserModel Validate(string user, string mdp)
        {
            if (mdp != null || user != "" || user != null)
            {
                Context.M2LinkContext c = new Context.M2LinkContext();
                UserRepository r = new UserRepository(c);
                //test si l'user n'appartient pas au registre des users
                User u = r.GetUserByPseudo(user);
                if (u == null)
                {
                    return null;
                }
                if (!u.Mdp.Equals(mdp))
                {
                        return null;
                }
                UserModel userM = new UserModel
                {
                Pseudo = user,
                UserId = u.UserId
                };
                return userM;
                } 
            return null;
        }
    }
}
