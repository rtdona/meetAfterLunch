using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unamed.Oauth2
{
    interface IOAuthHelper<Client>
    {
        void StartAuthCodeUri();

        //Task CodeFlowGetAccessTokenAsync(string code);

        Client GetClient();
    }
}