using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduate.AppClient.Dropbox
{
    public partial class DropboxAppClient : IAppClient
    {
        private static readonly DropboxAppClient _instance = new DropboxAppClient();

        private DropboxAppClient() { }

        public static DropboxAppClient Instance 
        {
            get
            {
                return _instance;
            }
        }
    }
}
