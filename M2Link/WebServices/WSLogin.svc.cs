using M2Link.Entities;
using M2Link.WebServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

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
            if (mdp != null)
            {
                if (mdp.Length > 8)
                {
                    Regex r = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                    if (r.IsMatch(mdp))
                    {
                        if (user != "" || user != null)
                        {
                            UserModel userM = new UserModel
                            {
                                Pseudo = user,
                                Mdp = mdp
                            };
                            return userM;
                        }
                    }
                }
            }
            return null;
        }
    }
}
